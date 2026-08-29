[![](https://img.shields.io/nuget/v/soenneker.quark.gen.simpleicons.abstractions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.gen.simpleicons.abstractions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.gen.simpleicons.abstractions/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.gen.simpleicons.abstractions/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.gen.simpleicons.abstractions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.gen.simpleicons.abstractions/)

# Soenneker.Quark.Gen.SimpleIcons.Abstractions

Provides SVG markup for Simple Icons by name. Implement and register when using the SimpleIcon element with Soenneker.Quark.Gen.SimpleIcons.

## Install

```bash
dotnet add package Soenneker.Quark.Gen.SimpleIcons.Abstractions
```

## Quick start

```csharp
using Soenneker.Quark.Gen.SimpleIcons.Abstractions.Registrars;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
var result = services.AddSimpleIconsSvgProviderAsSingleton();
```

Adds `ISimpleIconsSvgProvider` as a singleton service.

## What you get

- `ISimpleIconsSvgProvider` — Provides SVG markup for Simple Icons by name. Implement and register when using the SimpleIcon element with Soenneker.Quark.Gen.SimpleIcons.
- `ISimpleIconsSvgProviderRegistrar` — Registration helpers for Simple Icons SVG providers.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `ISimpleIconsSvgProviderRegistrar.AddSimpleIconsSvgProviderAsSingleton(services)` | Adds `ISimpleIconsSvgProvider` as a singleton service. | The same service collection, so additional registrations can be chained. |
| `ISimpleIconsSvgProviderRegistrar.AddSimpleIconsAsScoped(services)` | Adds `ISimpleIconsSvgProvider` as a scoped service. | The same service collection, so additional registrations can be chained. |
