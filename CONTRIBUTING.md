# Contributing

## Development setup

Install the .NET SDK selected by `global.json`, then run:

```powershell
dotnet restore .\ACMP.slnx
dotnet build .\ACMP.slnx --configuration Release --no-restore
dotnet test .\ACMP.slnx --configuration Release --no-build
```

To validate the binary PowerShell module:

```powershell
.\build\Build-PowerShellModule.ps1 -Version 0.0.0

$manifestPath = '.\artifacts\powershell\ACMP\ACMP.psd1'
Test-ModuleManifest -Path $manifestPath
Import-Module -Name $manifestPath -Force
Get-Command -Module ACMP
```

Do not add real Marketplace credentials, account identifiers, session tokens,
customer data, or downloaded vendor specifications to the repository, tests,
examples, issues, or build logs. Tests must use fake HTTP handlers and reserved
example domains.

Changes to public C# types or PowerShell command names should include tests and
be called out as compatibility changes.
