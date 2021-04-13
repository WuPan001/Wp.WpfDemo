using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Wp.WpfDemo.UIL.TestPrism.ViewModels.Windows
{
    public class MainWindowVM : BindableBase
    {
        #region 属性、字段

        private string testText;

        public string TestText
        {
            get { return testText; }
            set { SetProperty(ref testText, value); }
        }

        #region 命令

        private ICommand clickCmd;
        public ICommand ClickCmd => clickCmd ?? (clickCmd = new DelegateCommand(() => TestText = DateTime.Now.ToString()).ObservesCanExecute(() => IsCanExcute));
        private DelegateCommand _asyncCmd;

        public DelegateCommand AsyncCmd =>
         _asyncCmd ?? (_asyncCmd = new DelegateCommand(async () =>
         {
             await Task.Run(() =>
             {
                 Thread.Sleep(5000);
                 TestText = "Hello Prism!";
             });
         }));

        private bool _isCanExcute;

        public bool IsCanExcute
        {
            get { return _isCanExcute; }
            set { SetProperty(ref _isCanExcute, value); }
        }

        private DelegateCommand _getCurrentTimeCommand;

        public DelegateCommand GetCurrentTimeCommand =>
           _getCurrentTimeCommand ?? (_getCurrentTimeCommand = new DelegateCommand(ExecuteGetCurrentTimeCommand).ObservesCanExecute(() => IsCanExcute));

        private void ExecuteGetCurrentTimeCommand()
        {
            TestText = DateTime.Now.ToString();
        }

        #endregion 命令

        #endregion 属性、字段

        #region 方法

        //

        #endregion 方法

        #region 事件

        //

        #endregion 事件
    }
}