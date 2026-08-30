namespace Soenneker.Quark.Gen.SimpleIcons.Abstractions;

/// <summary>
/// Provides SVG markup for Simple Icons by their PascalCase member names.
/// </summary>
public interface ISimpleIconsSvgProvider
{
    /// <summary>
    /// Gets the SVG markup for a Simple Icon.
    /// </summary>
    /// <param name="iconName">The PascalCase icon member name, such as <c>Github</c>.</param>
    /// <returns>The SVG markup, or <see langword="null"/> when the icon is unavailable.</returns>
    string? GetSvg(string iconName);
}
