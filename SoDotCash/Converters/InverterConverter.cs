using System;
using System.Globalization;
using System.Windows.Data;

namespace SoDotCash.Converters
{

    /// <summary>
    /// This converter inverts the sign on numeric values.
    /// This is useful for 'flipping' graphs about the x-axis.
    /// </summary>
    public class InverterConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Convert int, decimal, float and double
            if (value is int)
                return -(int) value;
            if (value is decimal)
                return -(decimal) value;
            if (value is float)
                return -(float) value;
            if (value is double)
                return -(double) value;

            // Pass-through unhandled types
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Operation is bi-directional. Reversing is the same as applying the original conversion.
            return Convert(value, targetType, parameter, culture);
        }
    }
}