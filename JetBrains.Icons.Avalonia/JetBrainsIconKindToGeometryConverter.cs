

using System.Globalization;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;

namespace JetBrains.Icons.Avalonia {
    public class JetBrainsIconKindToGeometryConverter : IValueConverter {
        public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture) {
            if (value is JetBrainsIconKind kind) {
                return Geometry.Parse(JetBrainsIconDataProvider.GetData(kind));
            }

            return BindingOperations.DoNothing;
        }

        public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture) {
            throw new NotSupportedException();
        }
    }
}
