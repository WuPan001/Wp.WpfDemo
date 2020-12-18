using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using Wp.WpfDemo.Model.Enums;

namespace Wp.WpfDemo.BLL.Converters.NavigationConverters
{
    public class NavigationIconConverter : IValueConverter
    {
        public Style Home { get; set; }
        public Style SystemSetting { get; set; }
        public Style ContactUs { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is null)
            {
                return null;
            }
            else
            {
                switch ((ENavigationItem)value)
                {
                    //case ENavigationItem.Home:
                    //    return Home;

                    //case ENavigationItem.SystemSetting:
                    //    return SystemSetting;

                    //case ENavigationItem.ContactUs:
                    //    return ContactUs;

                    default:
                        return null;
                }
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}