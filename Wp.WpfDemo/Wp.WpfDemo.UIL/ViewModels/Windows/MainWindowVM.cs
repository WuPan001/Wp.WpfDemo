using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Wp.Helpers;
using Wp.WpfDemo.Model.Enums;

namespace Wp.WpfDemo.UIL.ViewModels.Windows
{
    internal class MainWindowVM : WindowVMBase
    {
        #region 事件

        //

        #endregion 事件

        #region 属性、字段

        /// <summary>
        /// 导航栏枚举集合
        /// </summary>
        public ObservableCollection<ENavigationItem> NavigationItems { get { return EnumHelper.GetEnumItems<ENavigationItem>(); } }

        //private UserInfo _currentUserInfo = new UserInfo();

        ///// <summary>
        ///// 当前用户信息
        ///// </summary>
        //public UserInfo CurrentUserInfo { get { return _currentUserInfo; } set { _currentUserInfo = value; RaisePropertyChanged(); } }

        #region 命令

        public ICommand NavigationItemClickCmd => new RelayCommand<TreeViewItem>(tv => tv.IsExpanded = !tv.IsExpanded);

        #endregion 命令

        #endregion 属性、字段

        #region 方法

        //

        #endregion 方法
    }
}