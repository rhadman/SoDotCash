using System;
using System.Globalization;
using System.Windows.Data;

namespace SoDotCash.Converters
{
    /// <summary>
    /// Convert a value to a bool indicating whether the value is not null.
    /// True - The value is not null
    /// False - The value is null
    /// </summary>
    public class IsNotNullConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}