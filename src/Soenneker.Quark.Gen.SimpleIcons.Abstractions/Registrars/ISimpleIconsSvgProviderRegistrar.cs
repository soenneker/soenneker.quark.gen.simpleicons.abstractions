using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Soenneker.Quark.Gen.SimpleIcons.Abstractions.Registrars;

/// <summary>
/// Registration helpers for Simple Icons SVG providers.
/// </summary>
public static class ISimpleIconsSvgProviderRegistrar
{
    /// <summary>
    /// Adds <see cref="ISimpleIconsSvgProvider"/> as a singleton service.
    /// </summary>
    public static IServiceCollection AddSimpleIconsSvgProviderAsSingleton<TProvider>(this IServiceCollection services)
        where TProvider : class, ISimpleIconsSvgProvider
    {
        services.TryAddSingleton<ISimpleIconsSvgProvider, TProvider>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="ISimpleIconsSvgProvider"/> as a scoped service.
    /// </summary>
    public static IServiceCollection AddSimpleIconsSvgProviderAsScoped<TProvider>(this IServiceCollection services)
        where TProvider : class, ISimpleIconsSvgProvider
    {
        services.TryAddScoped<ISimpleIconsSvgProvider, TProvider>();

        return services;
    }
}
