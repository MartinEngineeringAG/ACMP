# ACMP

ACMP is a .NET client and binary PowerShell module for the ALSO Cloud
Marketplace Simple API.

This is an independent community project. It is not an official ALSO product
and is not supported or endorsed by ALSO.

The API contract is documented in the
[official Swagger documentation](https://app.swaggerhub.com/apis/MarketplaceSimpleAPI/MarketplaceSimpleAPI/1.0.0).
The vendor specification is not redistributed in this repository.

## Packages

- `ACMP` on NuGet contains the reusable .NET client and typed request and
  response models.
- `ACMP` on PowerShell Gallery contains the binary PowerShell module. It
  bundles the .NET client and all runtime assemblies needed by the module.

Both packages are built from the same source revision and use the same version.

## .NET usage

Install the package:

```console
dotnet add package ACMP
```

Create and authenticate a client. Supply the base URI and credentials through
your application's secure configuration:

```csharp
using ACMP;

var baseUri = new Uri("https://marketplace.example.com/SimpleAPI");

using var client = new AcmpClient(baseUri);
await client.ConnectAsync(username, password);

var companies = await client.GetCompaniesAsync(parentAccountId);

await client.DisconnectAsync();
```

The client also accepts an `HttpClient` or `HttpMessageHandler`, allowing
applications to control connection lifetime and test requests without a live
Marketplace account.

## PowerShell usage

Install and import the module:

```powershell
Install-Module -Name ACMP -Scope CurrentUser
Import-Module -Name ACMP
```

Connect using a credential obtained at runtime:

```powershell
$credential = Get-Credential

$connectionParameters = @{
    BaseUri    = 'https://marketplace.example.com/SimpleAPI'
    Credential = $credential
}
Connect-ACMP @connectionParameters

Get-ACMPCompanies -ParentAccountId $parentAccountId

Disconnect-ACMP
```

Generated request models remain available for advanced payloads:

```powershell
$request = [ACMP.Models.GetSubscriptionRequest]::new()
$request.AccountId = $accountId

Get-ACMPSubscription -Request $request
```

Discover the complete command surface after importing the module:

```powershell
Get-Command -Module ACMP
```

## Build and test

The repository requires the .NET 10 SDK.

```powershell
dotnet restore .\ACMP.slnx
dotnet build .\ACMP.slnx --configuration Release --no-restore
dotnet test .\ACMP.slnx --configuration Release --no-build

.\build\Build-PowerShellModule.ps1 -Version 0.0.0
```

The staged PowerShell module is written to
`artifacts\powershell\ACMP`.

## Releases

A release tag named `vX.Y.Z` builds both packages with version `X.Y.Z`.
Publishing is performed only by the protected GitHub release workflow.

See [SECURITY.md](SECURITY.md) for reporting security issues and
[CONTRIBUTING.md](CONTRIBUTING.md) for development guidance.

## License and support

ACMP is licensed under the [MIT License](LICENSE).

The software is provided as-is, without warranty or liability as described in
the license. Martin Engineering AG does not provide support or service
commitments for this project.
