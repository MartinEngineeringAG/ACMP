# Building and releasing ACMP

This document describes the maintainer workflow for building, testing, and
publishing the ACMP packages.

## Prerequisites

- .NET 10 SDK
- Git with the complete repository history and tags
- PowerShell 7 for the build scripts
- Windows PowerShell 5.1 when validating Desktop compatibility locally

## Local build and test

Restore locked dependencies, build the solution, and run the offline tests:

```powershell
dotnet restore .\ACMP.slnx --locked-mode
dotnet build .\ACMP.slnx --configuration Release --no-restore
dotnet test .\ACMP.slnx --configuration Release --no-build
```

Build and validate the NuGet package:

```powershell
dotnet pack .\src\ACMP\ACMP.csproj `
    --configuration Release `
    --no-build `
    --output .\artifacts\nuget

.\build\Test-NuGetPackage.ps1 `
    -PackageDirectory .\artifacts\nuget
```

Build and validate the PowerShell module:

```powershell
.\build\Build-PowerShellModule.ps1
.\build\Test-PowerShellModule.ps1

powershell.exe `
    -NoLogo `
    -NoProfile `
    -ExecutionPolicy Bypass `
    -File .\build\Test-PowerShellModule.ps1
```

The generated packages are written to:

- `artifacts\nuget`
- `artifacts\powershell\ACMP`

## Versioning

[MinVer](https://github.com/adamralph/minver) calculates versions from Git tags
and commit height in local builds, Visual Studio, and GitHub Actions. GitHub
Actions checks out the complete history so it uses the same versioning model as
a regular local clone.

The products use independent tag prefixes:

- `acmp-vX.Y.Z` versions the NuGet package and `ACMP.dll`.
- `acmp-powershell-vX.Y.Z` versions the PowerShell Gallery module and
  `ACMP.PowerShell.dll`.

Before the first matching tag, an untagged build uses a version such as
`0.0.0-alpha.0.12`. After version `1.0.0`, the next untagged build uses a
version such as `1.0.1-alpha.0.1`. The assembly informational version also
contains the full Git commit.

The PowerShell module manifest derives its version from
`ACMP.PowerShell.dll`. For local prerelease builds, punctuation is removed from
the prerelease label so the generated manifest remains compatible with Windows
PowerShell 5.1. For example, `0.0.0-alpha.0.12` becomes
`0.0.0-alpha012` in the module manifest.

## Continuous integration

The CI workflow runs for pull requests targeting `main` and pushes to `main`.
It:

- builds and tests on Windows and Linux;
- checks vulnerable and deprecated dependencies;
- creates downloadable NuGet and PowerShell artifacts;
- verifies that the NuGet package can be consumed by a clean project;
- validates the PowerShell module under PowerShell 7 and 5.1; and
- scans the repository with Gitleaks.

CI artifacts are test packages only. Merging a pull request does not publish
anything to NuGet or PowerShell Gallery.

## Preparing a release

Run the `Prepare Release` workflow manually from the GitHub Actions page after
the release changes have been merged to `main`. Select `main` in the workflow
branch selector and enter:

- the release type;
- the ACMP NuGet version for a combined release; and
- the PowerShell module version.

Enter versions as `X.Y.Z` without `v`, a tag prefix, or a prerelease label. The
workflow constructs the `acmp-vX.Y.Z` and `acmp-powershell-vX.Y.Z` tags. Fixed
release versions are not stored in the project files.

The workflow creates the tags locally first, then:

- verifies that the versions move forward and are not already published;
- rejects PowerShell-only releases containing unreleased .NET client changes;
- builds and tests the current `main` commit;
- verifies package, manifest, and assembly versions;
- requires the NuGet package, symbol package, and PowerShell module archive; and
- records their sizes and SHA-256 hashes in `release-manifest.json`.

Only after all checks pass does the workflow atomically push the tags and create
a draft GitHub release containing the exact validated assets. A failed build
therefore does not create remote tags or a GitHub release.

## Combined release

A change to the .NET client requires a release of both products:

1. Merge the release commit to `main`.
2. Run `Prepare Release`.
3. Select `combined` and enter both versions.
4. Review the generated draft release, release notes, tags, and assets.
5. Publish the draft release.

The draft uses the `acmp-vX.Y.Z` tag as its primary tag. Publishing it triggers
the protected `Publish Release` workflow.

## PowerShell-only release

When only the PowerShell module changed:

1. Merge the release commit to `main`.
2. Run `Prepare Release`.
3. Select `powershell-only`, leave the ACMP version empty, and enter the
   PowerShell version.
4. Review and publish the generated draft release.

The release workflow rejects a PowerShell-only release if:

- the .NET client changed after its latest `acmp-vX.Y.Z` tag; or
- the corresponding ACMP package is not available from NuGet.

The locally built `ACMP.dll` bundled with the module is assigned the latest
published ACMP version. The PowerShell release does not publish a new NuGet
package.

## Publishing a prepared release

Publishing the draft GitHub release triggers the `Publish Release` workflow.
It does not rebuild the packages. It:

- downloads the assets attached to the published release;
- verifies their commit, tags, names, sizes, and SHA-256 hashes against
  `release-manifest.json`;
- verifies that the release commit is contained in `main`;
- passes the same validated assets to the protected `Release` environment;
- pushes the prepared `.nupkg` to NuGet; and
- extracts and publishes the prepared PowerShell module archive.

If publication fails after the release has been published, fix the workflow on
`main`, then run `Publish Release` manually with the existing primary release
tag. The retry downloads and validates the published assets again, skips
packages that already exist, and publishes any missing package.

The `.nupkg`, `ACMP.dll`, and `ACMP.PowerShell.dll` published by this process
are the files produced by the preparation build.

## Publishing credentials

The publishing job uses the protected `Release` GitHub environment.

- NuGet authentication uses trusted publishing and the `NUGET_USER` GitHub
  Actions configuration variable.
- PowerShell Gallery publishing uses the protected `PSGALLERY_API_KEY` secret.

Do not place publishing credentials in source files, workflow parameters, build
artifacts, or release notes.
