[![](https://img.shields.io/nuget/v/soenneker.quark.gen.simpleicons.abstractions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.gen.simpleicons.abstractions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.gen.simpleicons.abstractions/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.gen.simpleicons.abstractions/actions/workflows/publish-package.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.gen.simpleicons.abstractions/build-and-test.yml?label=Build&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.gen.simpleicons.abstractions/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.gen.simpleicons.abstractions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.gen.simpleicons.abstractions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.gen.simpleicons.abstractions/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.gen.simpleicons.abstractions/actions/workflows/codeql.yml)

# Soenneker.Quark.Gen.SimpleIcons.Abstractions

The SVG-provider contract shared by Quark Simple Icons components and build-time generation.

## Install

```bash
dotnet add package Soenneker.Quark.Gen.SimpleIcons.Abstractions
```

Most applications should install `Soenneker.Quark.Gen.SimpleIcons`, which references this package and generates an implementation. Reference this package directly when a library needs only the contract or when supplying a custom provider.

## Custom provider

```csharp
using Microsoft.Extensions.DependencyInjection;
using Soenneker.Quark.Gen.SimpleIcons.Abstractions;
using Soenneker.Quark.Gen.SimpleIcons.Abstractions.Registrars;

public sealed class CustomSimpleIconsSvgProvider : ISimpleIconsSvgProvider
{
    public string? GetSvg(string iconName) => iconName switch
    {
        "Github" => "<svg><!-- trusted markup --></svg>",
        _ => null
    };
}

services.AddSimpleIconsAsScoped<CustomSimpleIconsSvgProvider>();
```

Icon names use the PascalCase `SimpleIcon` member name. `GetSvg` returns `null` when the provider does not contain that icon.

## Registration lifetime

- `AddSimpleIconsAsScoped<TProvider>()` creates one provider per scope and supports providers with scoped dependencies.
- `AddSimpleIconsSvgProviderAsSingleton<TProvider>()` creates one provider for the application. Use it only when the provider and all of its dependencies are singleton-safe.

Both methods use `TryAdd`, so an existing `ISimpleIconsSvgProvider` registration is preserved.

The returned string is SVG markup and may be rendered as raw markup by the consuming component. Custom providers should return only trusted or sanitized SVG content.
