using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;
using Wp.WpfDemo.Model.Enums;
using Wp.WpfDemo.UIL.Views.Pages;

namespace Wp.WpfDemo.UIL.Converters
{
    internal class FrameContentConverter : IValueConverter
    {
        private readonly Dictionary<TreeViewItem, Page> _pagePool = new Dictionary<TreeViewItem, Page>();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is null)
            {
                return null;
            }
            else
            {
                if ((value as TreeViewItem).Tag == null)
                {
                    return null;
                }
                else
                {
                    return GetPage(value as TreeViewItem);
                }
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        private Page GetPage(TreeViewItem item)
        {
            if (_pagePool.ContainsKey(item))
            {
                return _pagePool[item];
            }
            else
            {
                GetNavigationItem(item);
                return GetPage(item);
            }
        }

        private void GetNavigationItem(TreeViewItem item)
        {
            switch (item.Tag)
            {
                case ENavigationItem.Home:
                    _pagePool.Add(item, new HomePage());
                    break;

                case ENavigationItem.ContactUs:
                    _pagePool.Add(item, new ContactUsPage());
                    break;

                default:
                    _pagePool.Add(item, null);
                    break;
            }
        }
    }
}