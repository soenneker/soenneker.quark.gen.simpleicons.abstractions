namespace Soenneker.Quark.Gen.SimpleIcons.Abstractions.Tests;

internal sealed class TestSimpleIconsSvgProvider : ISimpleIconsSvgProvider
{
    public string? GetSvg(string iconName) => iconName == "Github" ? "<svg />" : null;
}
