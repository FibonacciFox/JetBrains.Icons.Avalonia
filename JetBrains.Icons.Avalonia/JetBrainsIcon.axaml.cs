using Avalonia;
using Avalonia.Controls.Primitives;

namespace JetBrains.Icons.Avalonia;

public class JetBrainsIcon : TemplatedControl {
    public static readonly StyledProperty<JetBrainsIconKind> KindProperty
        = AvaloniaProperty.Register<JetBrainsIcon, JetBrainsIconKind>(nameof(Kind));

    /// <summary>
    /// Gets or sets the icon to display.
    /// </summary>
    public JetBrainsIconKind Kind {
        get => GetValue(KindProperty);
        set => SetValue(KindProperty, value);
    }
}