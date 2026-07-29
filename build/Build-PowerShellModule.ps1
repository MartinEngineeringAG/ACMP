[CmdletBinding()]
param(
    [Parameter()]
    [ValidateSet('Debug', 'Release')]
    [string]$Configuration = 'Release',

    [Parameter()]
    [ValidatePattern('^\d+\.\d+\.\d+$')]
    [string]$AcmpVersionOverride,

    [Parameter()]
    [string]$OutputPath,

    [Parameter()]
    [uri]$ProjectUri,

    [Parameter()]
    [uri]$LicenseUri
)

$ErrorActionPreference = 'Stop'

if (-not $PSBoundParameters.ContainsKey('OutputPath')) {
    $OutputPath = Join-Path $PSScriptRoot '..\artifacts\powershell'
}

$repositoryRoot = [System.IO.Path]::GetFullPath((Join-Path $PSScriptRoot '..'))
$resolvedOutputPath = [System.IO.Path]::GetFullPath($OutputPath)
$artifactsRoot = [System.IO.Path]::GetFullPath((Join-Path $repositoryRoot 'artifacts'))
$artifactsPrefix = $artifactsRoot.TrimEnd(
    [System.IO.Path]::DirectorySeparatorChar,
    [System.IO.Path]::AltDirectorySeparatorChar) + [System.IO.Path]::DirectorySeparatorChar

$outputIsArtifactsRoot = $resolvedOutputPath.Equals(
    $artifactsRoot,
    [System.StringComparison]::OrdinalIgnoreCase)
$outputIsInsideArtifacts = $resolvedOutputPath.StartsWith(
    $artifactsPrefix,
    [System.StringComparison]::OrdinalIgnoreCase)

if (-not ($outputIsArtifactsRoot -or $outputIsInsideArtifacts)) {
    throw "OutputPath '$resolvedOutputPath' must be inside '$artifactsRoot'."
}

$publishPath = Join-Path $resolvedOutputPath '.publish'
$modulePath = Join-Path $resolvedOutputPath 'ACMP'
$projectPath = Join-Path $repositoryRoot 'src\ACMP.PowerShell\ACMP.PowerShell.csproj'
$manifestSourcePath = Join-Path $repositoryRoot 'module\ACMP.psd1'
$manifestPath = Join-Path $modulePath 'ACMP.psd1'

foreach ($generatedPath in @($publishPath, $modulePath)) {
    if (Test-Path -LiteralPath $generatedPath) {
        Remove-Item -LiteralPath $generatedPath -Recurse -Force
    }
}

$null = New-Item -ItemType Directory -Path $resolvedOutputPath -Force
$null = New-Item -ItemType Directory -Path $publishPath -Force
$null = New-Item -ItemType Directory -Path $modulePath -Force

$publishArguments = @(
    'publish',
    $projectPath,
    '--configuration',
    $Configuration,
    '--output',
    $publishPath,
    '--no-restore',
    '--nologo'
)
if ($PSBoundParameters.ContainsKey('AcmpVersionOverride')) {
    $publishArguments += "-p:AcmpVersionOverride=$AcmpVersionOverride"
}

$publishOutput = & dotnet $publishArguments
if ($LASTEXITCODE -ne 0) {
    throw "dotnet publish failed with exit code $LASTEXITCODE."
}
$publishOutput | Write-Host

Copy-Item -Path (Join-Path $publishPath '*') -Destination $modulePath -Recurse
Copy-Item -LiteralPath $manifestSourcePath -Destination $manifestPath

$licensePath = Join-Path $repositoryRoot 'LICENSE'
if (Test-Path -LiteralPath $licensePath -PathType Leaf) {
    Copy-Item -LiteralPath $licensePath -Destination $modulePath
}

$binaryModulePath = Join-Path $modulePath 'ACMP.PowerShell.dll'
$productVersion = [System.Diagnostics.FileVersionInfo]::GetVersionInfo(
    $binaryModulePath).ProductVersion
if ($productVersion -notmatch '^(?<Base>\d+\.\d+\.\d+)(?:-(?<Prerelease>[0-9A-Za-z.-]+))?(?:\+[0-9A-Za-z.-]+)?$') {
    throw "Assembly product version '$productVersion' is not a supported semantic version."
}

$moduleVersion = $Matches.Base
$prerelease = $Matches.Prerelease -replace '[^0-9A-Za-z]', ''

$manifestParameters = @{
    Path          = $manifestPath
    ModuleVersion = $moduleVersion
}
if ($prerelease) {
    $manifestParameters.Prerelease = $prerelease
}
if ($PSBoundParameters.ContainsKey('ProjectUri')) {
    $manifestParameters.ProjectUri = $ProjectUri
}
if ($PSBoundParameters.ContainsKey('LicenseUri')) {
    $manifestParameters.LicenseUri = $LicenseUri
}
Update-ModuleManifest @manifestParameters

$requiredFiles = @(
    'ACMP.psd1',
    'ACMP.PowerShell.dll',
    'ACMP.dll'
)
foreach ($requiredFile in $requiredFiles) {
    $requiredPath = Join-Path $modulePath $requiredFile
    if (-not (Test-Path -LiteralPath $requiredPath -PathType Leaf)) {
        throw "Expected module file '$requiredPath' was not created."
    }
}

if ($PSBoundParameters.ContainsKey('AcmpVersionOverride')) {
    $acmpAssemblyPath = Join-Path $modulePath 'ACMP.dll'
    $acmpProductVersion = [System.Diagnostics.FileVersionInfo]::GetVersionInfo(
        $acmpAssemblyPath).ProductVersion
    $expectedAcmpVersion = [regex]::Escape($AcmpVersionOverride)
    if ($acmpProductVersion -notmatch "^$expectedAcmpVersion(?:\+[0-9A-Za-z.-]+)?$") {
        throw "Bundled ACMP version '$acmpProductVersion' does not match '$AcmpVersionOverride'."
    }
}

$manifest = Test-ModuleManifest -Path $manifestPath
if ($manifest.Version.ToString() -ne $moduleVersion) {
    throw "Staged module version '$($manifest.Version)' does not match '$moduleVersion'."
}

Remove-Item -LiteralPath $publishPath -Recurse -Force
Write-Output $modulePath
