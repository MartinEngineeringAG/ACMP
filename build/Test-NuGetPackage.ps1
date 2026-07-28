[CmdletBinding()]
param(
    [Parameter(Mandatory)]
    [ValidateScript({ Test-Path -LiteralPath $PSItem -PathType Container })]
    [string]$PackageDirectory,

    [Parameter(Mandatory)]
    [ValidateNotNullOrEmpty()]
    [string]$Version
)

$ErrorActionPreference = 'Stop'

$repositoryRoot = [System.IO.Path]::GetFullPath((Join-Path $PSScriptRoot '..'))
$testRoot = Join-Path $repositoryRoot 'artifacts\package-smoke'
$projectPath = Join-Path $testRoot 'ACMP.PackageSmoke.csproj'
$programPath = Join-Path $testRoot 'Program.cs'
$packageSource = [System.IO.Path]::GetFullPath($PackageDirectory)
$nugetSource = 'https://api.nuget.org/v3/index.json'

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

dotnet restore $projectPath `
    --source $packageSource `
    --source $nugetSource `
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
