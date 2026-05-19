using Soenneker.Quark.Gen.SimpleIcons.Abstractions.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Quark.Gen.SimpleIcons.Abstractions.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class ISimpleIconsSvgProviderTests : HostedUnitTest
{
    private readonly IISimpleIconsSvgProvider _util;

    public ISimpleIconsSvgProviderTests(Host host) : base(host)
    {
        _util = Resolve<IISimpleIconsSvgProvider>(true);
    }

    [Test]
    public void Default()
    {

    }
}
