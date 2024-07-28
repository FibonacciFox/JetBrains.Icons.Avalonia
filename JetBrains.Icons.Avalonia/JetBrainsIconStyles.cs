using Avalonia.Markup.Xaml;
using Avalonia.Styling;

namespace JetBrains.Icons.Avalonia;

/// <summary>
/// Styles for Material.Icons.Avalonia library
/// </summary>
public sealed class JetBrainsIconStyles : Styles {
    /// <summary>
    /// Initializes a new instance of the <see>
    ///     <cref>JetBrainsThemeBase</cref>
    /// </see>
    /// class.
    /// </summary>
    /// <param name="serviceProvider">The parent's service provider.</param>
    public JetBrainsIconStyles(IServiceProvider? serviceProvider) {
        AvaloniaXamlLoader.Load(serviceProvider, this);
    }
}