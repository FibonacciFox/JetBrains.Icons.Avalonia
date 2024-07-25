
using System.Runtime.CompilerServices;

namespace JetBrains.Icons;

/// <summary>
/// Allows retrieving data for icons
/// </summary>
public partial class JetBrainsIconDataProvider {
    private static JetBrainsIconDataProvider _instance = new();

    /// <summary>
    /// Gets or sets the singleton instance of this provider
    /// </summary>
    public static JetBrainsIconDataProvider Instance {
        get => _instance;
        set {
            _instance = value ?? throw new ArgumentNullException(nameof(value));
        }
    }

    /// <summary>
    /// Gets the data for the specified icon using the <see cref="Instance"/>
    /// </summary>
    /// <param name="kind">The icon kind</param>
    /// <returns>SVG path for target icon kind</returns>

    public static string GetData(JetBrainsIconKind kind) => Instance.ProvideData(kind);
    /// <summary>
    /// Provides the data for the specified icon kind
    /// </summary>
    /// <param name="kind">The icon kind</param>
    /// <returns>SVG path for target icon kind</returns>
    public virtual partial string ProvideData(JetBrainsIconKind kind);
}

public partial class JetBrainsIconDataProvider
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public virtual partial string ProvideData(JetBrainsIconKind kind)
    {
        return kind switch
        {
            JetBrainsIconKind.Abacus =>
                "M9.92882 11.2428C9.78675 11.006 9.47962 10.9292 9.24283 11.0713C9.00604 11.2133 8.92926 11.5205 9.07133 11.7573L9.66717 12.7503C8.65751 13.4764 8 14.6614 8 16H16C16 14.6615 15.3425 13.4765 14.3329 12.7504L14.9288 11.7573C15.0709 11.5205 14.9941 11.2133 14.7573 11.0713C14.5205 10.9292 14.2134 11.006 14.0713 11.2428L13.4536 12.2723C13.003 12.0965 12.5128 12 12 12C11.4873 12 10.997 12.0965 10.5465 12.2723L9.92882 11.2428ZM10 14H11V15H10V14ZM14 14H13V15H14V14Z M5 2H11C11.5523 2 12 2.44772 12 3V11C12.3389 11 12.6707 11.0339 12.9917 11.0986L13 11.0847V3C13 1.89543 12.1046 1 11 1H5C3.89543 1 3 1.89543 3 3V13C3 14.1046 3.89543 15 5 15H7.10011C7.17077 14.6522 7.27753 14.3175 7.41627 14H5C4.44772 14 4 13.5523 4 13V3C4 2.44772 4.44772 2 5 2Z",
        };
    }
}