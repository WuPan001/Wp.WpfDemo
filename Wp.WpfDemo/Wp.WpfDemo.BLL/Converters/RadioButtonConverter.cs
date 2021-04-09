using System;
using System.Globalization;
using System.Windows.Data;

namespace Wp.WpfDemo.BLL.Converters
{
    public class RadioButtonConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || parameter == null)
            {
                return false;
            }
            else
            {
                return value.ToString().Equals(parameter.ToString());
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || parameter == null)
            {
                return null;
            }
            else
            {
                if ((bool)value)
                {
                    return parameter.ToString();
                }
                else
                {
                    return null;
                }
            }
        }
    }
}