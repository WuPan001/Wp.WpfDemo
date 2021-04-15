using System;
using System.Globalization;
using System.Windows.Data;
using Wp.Helpers;
using Wp.Helpers.Helpers;
using Wp.WpfDemo.Model.Enums;

namespace Wp.WpfDemo.BLL.Converters.NavigationConverters
{
    public class NavigationHeadConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is null)
            {
                return null;
            }
            else
            {
                return EnumHelper.GetEnumDescription((ENavigationItem)value);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}