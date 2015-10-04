using System;
using System.Globalization;
using System.Windows.Data;

namespace SoDotCash.Converters
{
    /// <summary>
    /// Converter which inverts the value of a boolean.
    /// Used for XAML bindings to allow inverting operation without duplicating ModelView functionality
    /// </summary>
    [ValueConversion(typeof(bool), typeof(bool))]
    public class BoolToInverseBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !(bool)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Reverse is the same as forward
            return Convert(value, targetType, parameter, culture);
        }
    }
}