using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Soenneker.TestHosts.Unit;
using Soenneker.Utils.Test;
using Soenneker.Quark.Gen.SimpleIcons.Abstractions.Registrars;

namespace Soenneker.Quark.Gen.SimpleIcons.Abstractions.Tests;

public sealed class Host : UnitTestHost
{
    public override Task InitializeAsync()
    {
        SetupIoC(Services);

        return base.InitializeAsync();
    }

    private static void SetupIoC(IServiceCollection services)
    {
        services.AddLogging(builder =>
        {
            builder.AddSerilog(dispose: false);
        });

        IConfiguration config = TestUtil.BuildConfig();
        services.AddSingleton(config);

        services.AddSimpleIconsAsScoped<TestSimpleIconsSvgProvider>();
    }

    private sealed class TestSimpleIconsSvgProvider : ISimpleIconsSvgProvider
    {
        public string? GetSvg(string iconName) => iconName == "Github" ? "<svg />" : null;
    }
}
