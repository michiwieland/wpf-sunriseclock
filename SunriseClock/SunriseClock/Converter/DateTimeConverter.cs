using System;
using System.Windows.Data;

namespace SunriseClock.Converter
{
    public class DateTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (DateTime) value - new DateTime(2010,10,10);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return new DateTime(2010, 10, 10) + (TimeSpan) value;
        }
    }
}
