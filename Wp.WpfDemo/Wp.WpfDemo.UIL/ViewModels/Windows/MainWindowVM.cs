using GalaSoft.MvvmLight.Command;
using HandyControl.Controls;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Wp.Helpers.Helpers;
using Wp.WpfDemo.Model.Entities;
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

        private UserInfo _currentUserInfo = new UserInfo();

        /// <summary>
        /// 当前用户信息
        /// </summary>
        public UserInfo CurrentUserInfo { get { return _currentUserInfo; } set { _currentUserInfo = value; RaisePropertyChanged(); } }

        private Visibility _testVisibility = Visibility.Collapsed;

        public Visibility TestVisibility { get { return _testVisibility; } set { _testVisibility = value; RaisePropertyChanged(); } }
        private bool _isHomeSelected = true;
        public bool IsHomeSelected { get { return _isHomeSelected; } set { _isHomeSelected = value; RaisePropertyChanged(); } }

        #region 命令

        public ICommand NavigationItemClickCmd => new RelayCommand<TreeViewItem>(tv => tv.IsExpanded = !tv.IsExpanded);
        public ICommand MsgBoxCmd => new RelayCommand(() => { Growl.Success("申请转运车拉走！", "Msg"); });

        public ICommand KeyCmd => new RelayCommand(() =>
        {
            switch (_testVisibility)
            {
                case Visibility.Visible:
                    TestVisibility = Visibility.Collapsed;
                    IsHomeSelected = true;
                    break;

                case Visibility.Hidden:
                case Visibility.Collapsed:
                    TestVisibility = Visibility.Visible;
                    break;

                default:
                    break;
            }
        });

        #endregion 命令

        #endregion 属性、字段

        #region 方法

        public MainWindowVM()
        {
            CurrentUserInfo = new UserInfo() { UserName = "张三", Authority = EUserAuthority.Temp };
        }

        #endregion 方法
    }
}