using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using System.Windows.Input;

namespace Wp.WpfDemo.UIL.ViewModels.Windows
{
    public class WindowVMBase : ViewModelBase
    {
        #region 字段、属性

        //

        #endregion 字段、属性

        #region 事件

        //

        #endregion 事件

        #region 命令

        public virtual ICommand CloseCmd => new RelayCommand<Window>(wd => wd?.Close());

        public ICommand ReductionCmd => new RelayCommand<Window>(wd => { wd.WindowState = wd.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized; });

        public ICommand MinCmd => new RelayCommand<Window>(wd => { wd.WindowState = WindowState.Minimized; });

        public ICommand LoadedCmd => new RelayCommand<Window>((wd) =>
        {
            wd.MouseMove += (sender, e) =>
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    wd.DragMove();
                };
            };
            //wd.MouseDoubleClick += (sender, e) => wd.WindowState = wd.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
        });

        #endregion 命令

        #region 方法

        //

        #endregion 方法
    }
}