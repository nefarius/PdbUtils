# PdbUtils

## Usage

```bash
git submodule add https://github.com/nefarius/PdbUtils.git ./pdbutils
```

Assuming your main project is `<ProjectRootDir>/src/webapp.csproj` put the following snippet in your `.csproj` and make sure the relative paths match your environment:

```xml
    <ItemGroup>
        <!-- Nefarius.Shared.PdbUtils -->
        <Compile Include="..\pdbutils\**\*.cs" LinkBase="Shared" Visible="false" />
    </ItemGroup>
```

## Used by

- [WinDbgSymbolsCachingProxy](https://github.com/nefarius/WinDbgSymbolsCachingProxy)
- [Nefarius.Utilities.ETW](https://github.com/nefarius/Nefarius.Utilities.ETW)

## Sources

- [`Microsoft.Build.NoTargets`](https://github.com/dotnet/sdk/issues/2511#issuecomment-2800573169)
