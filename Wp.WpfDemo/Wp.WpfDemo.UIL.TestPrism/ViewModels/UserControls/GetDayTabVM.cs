using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wp.WpfDemo.UIL.TestPrism.Interfaces;

namespace Wp.WpfDemo.UIL.TestPrism.ViewModels.UserControls
{
    internal class GetDayTabVM
    {
        private IAppCmds _appCmds;
        private bool _isCanExecute;

        public bool IsCanExecute
        {
            get { return _isCanExecute; }
            set { _isCanExecute = value; }
        }

        private string _currentDay;

        public string CurrentDay
        {
            get { return _currentDay; }
            set { _currentDay = value; }
        }

        private DelegateCommand _getDayCmd;

        public DelegateCommand GetDayCmd =>
           _getDayCmd ?? (_getDayCmd = new DelegateCommand(() => CurrentDay = DateTime.Now.ToString("dd")).ObservesCanExecute(() => IsCanExecute));

        public GetDayTabVM(IAppCmds appcmds)
        {
            _appCmds = appcmds;
            //给复合命令GetCurrentAllTimeCommand注册子命令GetDayCmd
            _appCmds.GetCurrentAllTimeCommand.RegisterCommand(GetDayCmd);
        }
    }
}