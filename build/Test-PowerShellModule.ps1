[CmdletBinding()]
param(
    [Parameter()]
    [string]$ModulePath,

    [Parameter()]
    [ValidatePattern('^\d+\.\d+\.\d+$')]
    [string]$ExpectedVersion,

    [Parameter()]
    [ValidatePattern('^\d+\.\d+\.\d+$')]
    [string]$ExpectedAcmpVersion
)

$ErrorActionPreference = 'Stop'

if (-not $PSBoundParameters.ContainsKey('ModulePath')) {
    $ModulePath = Join-Path $PSScriptRoot '..\artifacts\powershell\ACMP'
}

function Assert-SameCommandSet {
    param(
        [Parameter(Mandatory)]
        [string]$Name,

        [Parameter(Mandatory)]
        [string[]]$Expected,

        [Parameter(Mandatory)]
        [string[]]$Actual
    )

    $missing = @($Expected | Where-Object { $Actual -cnotcontains $PSItem })
    $unexpected = @($Actual | Where-Object { $Expected -cnotcontains $PSItem })

    if ($missing.Count -eq 0 -and $unexpected.Count -eq 0) {
        return
    }

    $details = @()
    if ($missing.Count -gt 0) {
        $details += "Missing: $($missing -join ', ')."
    }
    if ($unexpected.Count -gt 0) {
        $details += "Unexpected: $($unexpected -join ', ')."
    }

    throw "$Name does not match the module contract. $($details -join ' ')"
}

$resolvedModulePath = [System.IO.Path]::GetFullPath($ModulePath)
$manifestPath = Join-Path $resolvedModulePath 'ACMP.psd1'
$binaryModulePath = Join-Path $resolvedModulePath 'ACMP.PowerShell.dll'
$acmpAssemblyPath = Join-Path $resolvedModulePath 'ACMP.dll'

$requiredFiles = @(
    'ACMP.psd1',
    'ACMP.PowerShell.dll',
    'ACMP.dll',
    'LICENSE'
)
foreach ($requiredFile in $requiredFiles) {
    $requiredPath = Join-Path $resolvedModulePath $requiredFile
    if (-not (Test-Path -LiteralPath $requiredPath -PathType Leaf)) {
        throw "Expected module file '$requiredPath' was not found."
    }
}

$manifestData = Import-PowerShellDataFile -LiteralPath $manifestPath
if ($manifestData.RootModule -cne 'ACMP.PowerShell.dll') {
    throw "RootModule must be 'ACMP.PowerShell.dll', but is '$($manifestData.RootModule)'."
}

$productVersion = [System.Diagnostics.FileVersionInfo]::GetVersionInfo(
    $binaryModulePath).ProductVersion
if ($productVersion -notmatch '^(?<Base>\d+\.\d+\.\d+)(?:-(?<Prerelease>[0-9A-Za-z.-]+))?(?:\+[0-9A-Za-z.-]+)?$') {
    throw "Assembly product version '$productVersion' is not a supported semantic version."
}
$assemblyModuleVersion = $Matches.Base
$assemblyPrerelease = $Matches.Prerelease -replace '[^0-9A-Za-z]', ''
if ($manifestData.ModuleVersion.ToString() -cne $assemblyModuleVersion) {
    throw "Module version '$($manifestData.ModuleVersion)' does not match assembly version '$assemblyModuleVersion'."
}
$manifestPrerelease = [string]$manifestData.PrivateData.PSData.Prerelease
if ($manifestPrerelease -cne $assemblyPrerelease) {
    throw "Module prerelease '$manifestPrerelease' does not match assembly prerelease '$assemblyPrerelease'."
}

$declaredCmdlets = @($manifestData.CmdletsToExport)
if ($declaredCmdlets.Count -eq 0) {
    throw 'CmdletsToExport must explicitly declare at least one cmdlet.'
}

$wildcardCmdlets = @(
    $declaredCmdlets |
        Where-Object { [System.Management.Automation.WildcardPattern]::ContainsWildcardCharacters($PSItem) }
)
if ($wildcardCmdlets.Count -gt 0) {
    throw "CmdletsToExport must not contain wildcards: $($wildcardCmdlets -join ', ')."
}

$duplicateCmdlets = @(
    $declaredCmdlets |
        Group-Object |
        Where-Object Count -gt 1 |
        Select-Object -ExpandProperty Name
)
if ($duplicateCmdlets.Count -gt 0) {
    throw "CmdletsToExport contains duplicates: $($duplicateCmdlets -join ', ')."
}

$invalidNames = @($declaredCmdlets | Where-Object { $PSItem -cnotmatch '^[A-Za-z]+-ACMP[A-Za-z0-9]*$' })
if ($invalidNames.Count -gt 0) {
    throw "CmdletsToExport contains names outside the ACMP naming scheme: $($invalidNames -join ', ')."
}

$approvedVerbs = @((Get-Verb).Verb)
$unapprovedVerbs = @(
    $declaredCmdlets |
        ForEach-Object { $PSItem.Split('-', 2)[0] } |
        Where-Object { $approvedVerbs -cnotcontains $PSItem } |
        Sort-Object -Unique
)
if ($unapprovedVerbs.Count -gt 0) {
    throw "CmdletsToExport contains unapproved verbs: $($unapprovedVerbs -join ', ')."
}

if (@($manifestData.FunctionsToExport).Count -ne 0) {
    throw 'FunctionsToExport must remain empty for this binary module.'
}
if (@($manifestData.AliasesToExport).Count -ne 0) {
    throw 'AliasesToExport must remain empty for this binary module.'
}

$binaryAssembly = [System.Reflection.Assembly]::LoadFrom($binaryModulePath)
$implementedCmdlets = @(
    foreach ($type in $binaryAssembly.GetTypes()) {
        $attributes = @(
            $type.GetCustomAttributes([System.Management.Automation.CmdletAttribute], $false)
        )
        foreach ($attribute in $attributes) {
            if ($type.IsAbstract -or -not $type.IsPublic) {
                throw "Cmdlet type '$($type.FullName)' must be public and non-abstract."
            }
            if (-not [System.Management.Automation.Cmdlet].IsAssignableFrom($type)) {
                throw "Type '$($type.FullName)' has CmdletAttribute but does not derive from Cmdlet."
            }

            "$($attribute.VerbName)-$($attribute.NounName)"
        }
    }
)

$duplicateImplementations = @(
    $implementedCmdlets |
        Group-Object |
        Where-Object Count -gt 1 |
        Select-Object -ExpandProperty Name
)
if ($duplicateImplementations.Count -gt 0) {
    throw "The binary module implements duplicate cmdlet names: $($duplicateImplementations -join ', ')."
}

Assert-SameCommandSet `
    -Name 'Implemented cmdlets' `
    -Expected $declaredCmdlets `
    -Actual $implementedCmdlets

$manifest = Test-ModuleManifest -Path $manifestPath -ErrorAction Stop
if ($PSBoundParameters.ContainsKey('ExpectedVersion') -and
    $manifest.Version.ToString() -cne $ExpectedVersion) {
    throw "Module version '$($manifest.Version)' does not match expected version '$ExpectedVersion'."
}
if ($PSBoundParameters.ContainsKey('ExpectedVersion') -and $manifestPrerelease) {
    throw "Expected a stable module version, but found prerelease '$manifestPrerelease'."
}
if ($PSBoundParameters.ContainsKey('ExpectedAcmpVersion')) {
    $acmpProductVersion = [System.Diagnostics.FileVersionInfo]::GetVersionInfo(
        $acmpAssemblyPath).ProductVersion
    $expectedAcmpProductVersion = [regex]::Escape($ExpectedAcmpVersion)
    if ($acmpProductVersion -notmatch "^$expectedAcmpProductVersion(?:\+[0-9A-Za-z.-]+)?$") {
        throw "Bundled ACMP version '$acmpProductVersion' does not match '$ExpectedAcmpVersion'."
    }

    $acmpAssemblyVersion = [System.Reflection.AssemblyName]::GetAssemblyName(
        $acmpAssemblyPath).Version
    if ($acmpAssemblyVersion.ToString() -cne "$ExpectedAcmpVersion.0") {
        throw "Bundled ACMP assembly version '$acmpAssemblyVersion' does not match '$ExpectedAcmpVersion'."
    }
}

Remove-Module -Name ACMP -Force -ErrorAction SilentlyContinue
try {
    $null = Import-Module -Name $manifestPath -Force -ErrorAction Stop
    $exportedCommands = @(Get-Command -Module ACMP)
    $unexpectedCommandTypes = @(
        $exportedCommands |
            Where-Object CommandType -ne 'Cmdlet' |
            ForEach-Object { "$($PSItem.Name) ($($PSItem.CommandType))" }
    )
    if ($unexpectedCommandTypes.Count -gt 0) {
        throw "The module exports non-cmdlet commands: $($unexpectedCommandTypes -join ', ')."
    }

    Assert-SameCommandSet `
        -Name 'Imported cmdlets' `
        -Expected $declaredCmdlets `
        -Actual @($exportedCommands.Name)

    $reportColumn = [ACMP.Models.ReportColumn]::new()
    $reportColumn.CellIndex = 0
    $reportColumn.Name = 'Quantity'
    $reportColumn.Type = 'Decimal'
    $reportCell = [ACMP.Models.ReportCell]::new()
    $reportCell.Column = $reportColumn
    $reportCell.Value = [decimal]11
    $reportRow = [ACMP.Models.ReportRow]::new()
    $reportRow.Cells.Add($reportCell)
    if ($reportRow.Cells[0].Column.Name -cne 'Quantity' -or
        $reportRow.Cells[0].Value -ne 11) {
        throw 'Report rows must pair each value with its report column metadata.'
    }
}
finally {
    Remove-Module -Name ACMP -Force -ErrorAction SilentlyContinue
}

Write-Output "Validated $($declaredCmdlets.Count) ACMP cmdlets in PowerShell $($PSVersionTable.PSVersion)."
