using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using Wp.WpfDemo.UIL.Views.Windows;

namespace Wp.WpfDemo.UIL.ViewModels.Windows
{
    internal class LoginWindowVM : WindowVMBase
    {
        #region 事件

        //

        #endregion 事件

        #region 字段、属性

        private string _userName;

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get { return _userName; } set { _userName = value; RaisePropertyChanged(() => UserName); } }

        private string _pwd;

        /// <summary>
        /// 密码
        /// </summary>
        public string PWD { get { return _pwd; } set { _pwd = value; RaisePropertyChanged(() => PWD); } }

        //public ObservableCollection<string> UserNames => DbHelper.GetUserNames();
        private ObservableCollection<string> _userNames = new ObservableCollection<string>();

        public ObservableCollection<string> UserNames { get { return _userNames; } set { _userNames = value; RaisePropertyChanged(); } }

        #endregion 字段、属性

        #region 命令

        public ICommand LoginCmd
        {
            get
            {
                return new RelayCommand<Window>(wd =>
                {
                    var main = new MainWindow();
                    wd?.Close();
                    main.Show();
                    //try
                    //{
                    //    if (window != null)
                    //    {
                    //        var dataBaseHelper = new DataBaseHelper();
                    //        if (dataBaseHelper.Login(_userName, _pwd))
                    //        {
                    //            MainWindow mainWindow = new MainWindow();
                    //            window.Close();
                    //            mainWindow.ShowDialog();
                    //        }
                    //        else
                    //        {
                    //            new MessageWindow(new MessageWindowVM("用户名或密码错误，请重新输入！", Warn)).ShowDialog();
                    //        }
                    //    }
                    //}
                    //catch (Exception ex)
                    //{
                    //    new MessageWindow(new MessageWindowVM(ex.Message, Err)).ShowDialog();
                    //}
                });
            }
        }

        public ICommand WindowMoveCmd => new RelayCommand<Window>((wd) => wd.DragMove());

        #endregion 命令

        #region 方法

        //

        #endregion 方法
    }
}