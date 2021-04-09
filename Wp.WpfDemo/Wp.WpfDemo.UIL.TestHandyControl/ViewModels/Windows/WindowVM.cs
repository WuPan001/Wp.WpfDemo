using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using HandyControl.Controls;
using HandyControl.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace Wp.WpfDemo.UIL.TestHandyControl.ViewModels.Windows
{
    internal class WindowVM : ViewModelBase
    {
        #region 字段、属性

        //

        #region 命令

        public ICommand ScreenShotCmd => new RelayCommand(() =>
           {
               new Screenshot().Start();
           });

        private void Screenshot_Snapped(object sender, FunctionEventArgs<ImageSource> e)
        {
            Console.WriteLine(e);
        }

        #endregion 命令

        #endregion 字段、属性

        #region 方法

        public WindowVM()
        {
            Screenshot.Snapped += Screenshot_Snapped;
        }

        #endregion 方法

        #region 事件

        //

        #endregion 事件
    }
}