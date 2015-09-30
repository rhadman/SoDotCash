using System;
using System.Globalization;
using System.Windows.Data;

namespace SoDotCash.Converters
{
    [ValueConversion(typeof(int), typeof(bool))]
    class NumberToIsPositiveConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (decimal)value > 0 ? true : false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
