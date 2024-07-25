
using Avalonia.Markup.Xaml;

namespace JetBrains.Icons.Avalonia {
    public class JetBrainsIconExt : MarkupExtension {
        public JetBrainsIconExt() { }
        public JetBrainsIconExt(JetBrainsIconKind kind) {
            Kind = kind;
        }

        public JetBrainsIconExt(JetBrainsIconKind kind, double? size) {
            Kind = kind;
            Size = size;
        }
        
        [ConstructorArgument("kind")]
        public JetBrainsIconKind Kind { get; set; }

        [ConstructorArgument("size")]
        public double? Size { get; set; }
        
        public override object ProvideValue(IServiceProvider serviceProvider) {
            var result = new JetBrainsIcon { Kind = Kind };

            if (Size.HasValue)
            {
                result.Height = Size.Value;
                result.Width = Size.Value;
            }

            return result;
        }
    }
}