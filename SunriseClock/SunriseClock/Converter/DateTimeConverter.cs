using System;
using System.Windows.Data;

namespace SunriseClock.Converter
{
    public class DateTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var timeOfDay = ((DateTime)value).TimeOfDay;
            return timeOfDay;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var convertBack = new DateTime() + ((TimeSpan)value);
            return convertBack;
        }
    }
}
