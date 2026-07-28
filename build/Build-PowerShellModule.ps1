[CmdletBinding()]
param(
    [Parameter()]
    [ValidatePattern('^\d+\.\d+\.\d+$')]
    [string]$Version = '0.0.0',

    [Parameter()]
    [ValidateSet('Debug', 'Release')]
    [string]$Configuration = 'Release',

    [Parameter()]
    [string]$OutputPath = (Join-Path $PSScriptRoot '..\artifacts\powershell'),

    [Parameter()]
    [uri]$ProjectUri,

    [Parameter()]
    [uri]$LicenseUri
)

$ErrorActionPreference = 'Stop'

$repositoryRoot = [System.IO.Path]::GetFullPath((Join-Path $PSScriptRoot '..'))
$resolvedOutputPath = [System.IO.Path]::GetFullPath($OutputPath)
$repositoryPrefix = $repositoryRoot.TrimEnd(
    [System.IO.Path]::DirectorySeparatorChar,
    [System.IO.Path]::AltDirectorySeparatorChar) + [System.IO.Path]::DirectorySeparatorChar

if (-not $resolvedOutputPath.StartsWith($repositoryPrefix, [System.StringComparison]::OrdinalIgnoreCase)) {
    throw "OutputPath '$resolvedOutputPath' must be inside the repository."
}

$publishPath = Join-Path $resolvedOutputPath '.publish'
$modulePath = Join-Path $resolvedOutputPath 'ACMP'
$projectPath = Join-Path $repositoryRoot 'src\ACMP.PowerShell\ACMP.PowerShell.csproj'
$manifestSourcePath = Join-Path $repositoryRoot 'module\ACMP.psd1'
$manifestPath = Join-Path $modulePath 'ACMP.psd1'

if (Test-Path -LiteralPath $resolvedOutputPath) {
    Remove-Item -LiteralPath $resolvedOutputPath -Recurse -Force
}

$null = New-Item -ItemType Directory -Path $publishPath -Force
$null = New-Item -ItemType Directory -Path $modulePath -Force

$publishOutput = dotnet publish $projectPath `
    --configuration $Configuration `
    --output $publishPath `
    --no-restore `
    --nologo
if ($LASTEXITCODE -ne 0) {
    throw "dotnet publish failed with exit code $LASTEXITCODE."
}
$publishOutput | Write-Host

Copy-Item -Path (Join-Path $publishPath '*') -Destination $modulePath -Recurse
Copy-Item -LiteralPath $manifestSourcePath -Destination $manifestPath
Copy-Item -LiteralPath (Join-Path $repositoryRoot 'README.md') -Destination $modulePath

$licensePath = Join-Path $repositoryRoot 'LICENSE'
if (Test-Path -LiteralPath $licensePath -PathType Leaf) {
    Copy-Item -LiteralPath $licensePath -Destination $modulePath
}

$manifestParameters = @{
    Path          = $manifestPath
    ModuleVersion = $Version
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

$manifest = Test-ModuleManifest -Path $manifestPath
if ($manifest.Version.ToString() -ne $Version) {
    throw "Staged module version '$($manifest.Version)' does not match '$Version'."
}

Remove-Item -LiteralPath $publishPath -Recurse -Force
Write-Output $modulePath
