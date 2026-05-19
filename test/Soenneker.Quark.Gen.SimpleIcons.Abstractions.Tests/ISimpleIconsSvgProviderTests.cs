using System;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Quark.Gen.SimpleIcons.Abstractions.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class ISimpleIconsSvgProviderTests : HostedUnitTest
{
    private readonly ISimpleIconsSvgProvider _util;

    public ISimpleIconsSvgProviderTests(Host host) : base(host)
    {
        _util = Resolve<ISimpleIconsSvgProvider>(true);
    }

    [Test]
    public void Default()
    {
        if (_util.GetSvg("Github") != "<svg />")
            throw new InvalidOperationException("The test SVG provider did not return the expected markup.");
    }
}
