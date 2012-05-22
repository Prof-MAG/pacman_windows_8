

using System;
using System.Globalization;
using Windows.UI.Xaml.Data;
namespace Pacman
{
    public class StringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string culture)
        {
            return value == null ? 0 : System.Convert.ToDouble(value.ToString());
        }

        public object ConvertBack(object value, Type targetType, object parameter, string culture)
        {
            return value == null ? null : value.ToString();
        }
    }
}
