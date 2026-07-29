[CmdletBinding()]
param(
    [Parameter(Mandatory)]
    [ValidateScript({ Test-Path -LiteralPath $PSItem -PathType Container })]
    [string]$PackageDirectory,

    [Parameter()]
    [ValidatePattern('^\d+\.\d+\.\d+$')]
    [string]$ExpectedVersion
)

$ErrorActionPreference = 'Stop'

$repositoryRoot = [System.IO.Path]::GetFullPath((Join-Path $PSScriptRoot '..'))
$testRoot = Join-Path $repositoryRoot 'artifacts\package-smoke'
$projectPath = Join-Path $testRoot 'ACMP.PackageSmoke.csproj'
$programPath = Join-Path $testRoot 'Program.cs'
$nugetConfigPath = Join-Path $testRoot 'NuGet.Config'
$packageExtractPath = Join-Path $testRoot 'package'
$packageSource = [System.IO.Path]::GetFullPath($PackageDirectory)
$nugetSource = 'https://api.nuget.org/v3/index.json'
if ($PSBoundParameters.ContainsKey('ExpectedVersion')) {
    $packageName = "ACMP.$ExpectedVersion.nupkg"
    $packages = @(
        Get-ChildItem -LiteralPath $packageSource -Filter $packageName -File
    )
    if ($packages.Count -ne 1) {
        throw "Expected NuGet package '$packageName' in '$packageSource'."
    }
    $version = $ExpectedVersion
}
else {
    $packages = @(
        Get-ChildItem -LiteralPath $packageSource -Filter 'ACMP.*.nupkg' -File
    )
    if ($packages.Count -ne 1 -or
        $packages[0].Name -notmatch '^ACMP\.(?<Version>.+)\.nupkg$') {
        throw "Expected exactly one versioned ACMP NuGet package in '$packageSource'."
    }
    $version = $Matches.Version
}

if (Test-Path -LiteralPath $testRoot) {
    Remove-Item -LiteralPath $testRoot -Recurse -Force
}

dotnet new console `
    --name 'ACMP.PackageSmoke' `
    --output $testRoot `
    --framework 'net10.0' `
    --no-restore `
    --force
if ($LASTEXITCODE -ne 0) {
    throw "dotnet new failed with exit code $LASTEXITCODE."
}

Add-Type -AssemblyName System.IO.Compression.FileSystem
[System.IO.Compression.ZipFile]::ExtractToDirectory(
    $packages[0].FullName,
    $packageExtractPath)
$assemblyPath = Join-Path $packageExtractPath 'lib\netstandard2.0\ACMP.dll'
$assemblyName = [System.Reflection.AssemblyName]::GetAssemblyName($assemblyPath)
$fileVersion = [System.Diagnostics.FileVersionInfo]::GetVersionInfo($assemblyPath)
$baseVersion = $version.Split('-', 2)[0]
$expectedAssemblyVersion = "$baseVersion.0"
$escapedPackageVersion = [regex]::Escape($version)
if ($assemblyName.Version.ToString() -cne $expectedAssemblyVersion) {
    throw "Assembly version '$($assemblyName.Version)' does not match package version '$version'."
}
if ($fileVersion.FileVersion -cne $expectedAssemblyVersion) {
    throw "File version '$($fileVersion.FileVersion)' does not match package version '$version'."
}
if ($fileVersion.ProductVersion -notmatch "^$escapedPackageVersion(?:\+[0-9A-Za-z.-]+)?$") {
    throw "Product version '$($fileVersion.ProductVersion)' does not match package version '$version'."
}

dotnet add $projectPath package ACMP `
    --version $Version `
    --source $packageSource `
    --no-restore
if ($LASTEXITCODE -ne 0) {
    throw "dotnet add package failed with exit code $LASTEXITCODE."
}

$program = @'
using ACMP;

using var client = new AcmpClient(new Uri("https://marketplace.example.com/SimpleAPI"));
Console.WriteLine(client.BaseUri);
'@
[System.IO.File]::WriteAllText($programPath, $program, [System.Text.UTF8Encoding]::new($false))

$escapedPackageSource = [System.Security.SecurityElement]::Escape($packageSource)
$nugetConfig = @"
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <clear />
    <add key="local" value="$escapedPackageSource" />
    <add key="nuget.org" value="$nugetSource" protocolVersion="3" />
  </packageSources>
</configuration>
"@
[System.IO.File]::WriteAllText($nugetConfigPath, $nugetConfig, [System.Text.UTF8Encoding]::new($false))

dotnet restore $projectPath `
    --configfile $nugetConfigPath `
    --nologo
if ($LASTEXITCODE -ne 0) {
    throw "Package consumer restore failed with exit code $LASTEXITCODE."
}

dotnet build $projectPath `
    --configuration Release `
    --no-restore `
    --nologo
if ($LASTEXITCODE -ne 0) {
    throw "Package consumer build failed with exit code $LASTEXITCODE."
}
