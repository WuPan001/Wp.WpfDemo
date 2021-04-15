using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wp.WpfDemo.UIL.TestPrism.Interfaces;

namespace Wp.WpfDemo.UIL.TestPrism.ViewModels.UserControls
{
    internal class GetTimeTabVM
    {
        private IAppCmds _appCmds;
        private bool _isCanExecute;

        public bool IsCanExecute
        {
            get { return _isCanExecute; }
            set { _isCanExecute = value; }
        }

        private string _currentTime;

        public string CurrentTime
        {
            get { return _currentTime; }
            set { _currentTime = value; }
        }

        private DelegateCommand _getTimeCmd;

        public DelegateCommand GetTimeCmd =>
           _getTimeCmd ?? (_getTimeCmd = new DelegateCommand(() => CurrentTime = DateTime.Now.ToString("HH:mm:ss")).ObservesCanExecute(() => IsCanExecute));

        public GetTimeTabVM(IAppCmds appcmds)
        {
            _appCmds = appcmds;
            //给复合命令GetCurrentAllTimeCommand注册子命令GetTimeCmd
            _appCmds.GetCurrentAllTimeCommand.RegisterCommand(GetTimeCmd);
        }
    }
}