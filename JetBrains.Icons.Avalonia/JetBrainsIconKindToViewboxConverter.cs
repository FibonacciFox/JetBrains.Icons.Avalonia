using Avalonia;
using Avalonia.Controls;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System.Globalization;

namespace JetBrains.Icons.Avalonia;

public class JetBrainsIconKindToViewboxConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is JetBrainsIconKind kind)
        {
            // Получаем данные иконки из провайдера
            var dataProvider = JetBrainsIconDataProvider.Instance;
            var iconDataList = dataProvider.ProvideData(kind);

            // Создаем Viewbox и Grid для иконки
            var viewbox = new Viewbox();
            var grid = new Grid();

            foreach (var iconData in iconDataList)
            {
                // Создаем Path элемент для каждого пути иконки
                var path = new global::Avalonia.Controls.Shapes.Path
                {
                    Data = Geometry.Parse(iconData.Data),
                    Fill = iconData.Fill != null ? new SolidColorBrush(Color.Parse(iconData.Fill)) : null,
                    Opacity = iconData.Opacity
                };

                // Если указана трансформация, применяем её
                if (iconData.Transform.HasValue)
                {
                    path.RenderTransform = new TranslateTransform(iconData.Transform.Value.X, iconData.Transform.Value.Y);
                }

                grid.Children.Add(path);
            }

            viewbox.Child = grid;
            return viewbox;
        }

        return AvaloniaProperty.UnsetValue;
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture) =>
        throw new NotSupportedException();
}