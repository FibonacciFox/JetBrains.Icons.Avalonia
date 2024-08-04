using System;
using Avalonia.Data.Converters;
using System.Globalization;

namespace JetBrains.Icons.Avalonia
{
    public class JetBrainsIconKindToViewboxConverter : IValueConverter
    {
        public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is JetBrainsIconKind kind)
            {
                var dataProvider = JetBrainsIconDataProvider.Instance;
                var iconDataList = dataProvider.ProvideData(kind);

                if (iconDataList.Count > 0)
                {
                    return iconDataList[0].Resource;
                }
            }

            return null;
        }

        public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture) =>
            throw new NotSupportedException();
    }
}
