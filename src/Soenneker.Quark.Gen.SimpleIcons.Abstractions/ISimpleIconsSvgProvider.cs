namespace Soenneker.Quark.Gen.SimpleIcons.Abstractions;

/// <summary>
/// Provides SVG markup for Simple Icons by name.
/// Implement and register when using the SimpleIcon element with Soenneker.Quark.Gen.SimpleIcons.
/// </summary>
public interface ISimpleIconsSvgProvider
{
    /// <summary>
    /// Returns the SVG markup for the given Simple Icons enum name, or null if not found.
    /// </summary>
    string? GetSvg(string iconName);
}
