using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Quark.Gen.SimpleIcons.Abstractions.Abstract;

namespace Soenneker.Quark.Gen.SimpleIcons.Abstractions.Registrars;

/// <summary>
/// Abstractions for Quark Suite consumption of Simple Icons
/// </summary>
public static class ISimpleIconsSvgProviderRegistrar
{
    /// <summary>
    /// Adds <see cref="IISimpleIconsSvgProvider"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddISimpleIconsSvgProviderAsSingleton(this IServiceCollection services)
    {
        services.TryAddSingleton<IISimpleIconsSvgProvider, ISimpleIconsSvgProvider>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="IISimpleIconsSvgProvider"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddISimpleIconsSvgProviderAsScoped(this IServiceCollection services)
    {
        services.TryAddScoped<IISimpleIconsSvgProvider, ISimpleIconsSvgProvider>();

        return services;
    }
}
