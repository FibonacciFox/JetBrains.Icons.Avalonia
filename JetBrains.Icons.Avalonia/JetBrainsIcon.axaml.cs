using Avalonia;
using Avalonia.Controls.Primitives;

namespace JetBrains.Icons.Avalonia
{
    public class JetBrainsIcon : TemplatedControl
    {
        public static readonly StyledProperty<JetBrainsIconKind> KindProperty =
            AvaloniaProperty.Register<JetBrainsIcon, JetBrainsIconKind>(nameof(Kind));

        public JetBrainsIconKind Kind
        {
            get => GetValue(KindProperty);
            set => SetValue(KindProperty, value);
        }
    }
}