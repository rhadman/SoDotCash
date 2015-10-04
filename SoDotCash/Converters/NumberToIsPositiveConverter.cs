using System;
using System.Globalization;
using System.Windows.Data;

namespace SoDotCash.Converters
{
    /// <summary>
    /// Converter which produces a true value if the input value is greater than or equal to 0.
    /// While 0 is not technically positive, we use this to format money values so 0 is grouped with positive values here.
    /// </summary>
    [ValueConversion(typeof(int), typeof(bool))]
    class NumberToIsPositiveConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (decimal)value >= 0 ? true : false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
