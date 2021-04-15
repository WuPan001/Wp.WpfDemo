using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wp.WpfDemo.UIL.TestPrism.Interfaces;

namespace Wp.WpfDemo.UIL.TestPrism.ViewModels.UserControls
{
    internal class GetMonthTabVM
    {
        private IAppCmds _appCmds;
        private bool _isCanExecute;

        public bool IsCanExecute
        {
            get { return _isCanExecute; }
            set { _isCanExecute = value; }
        }

        private string _currentMonth;

        public string CurrentHour
        {
            get { return _currentMonth; }
            set { _currentMonth = value; }
        }

        private DelegateCommand _getMonthCmd;

        public DelegateCommand GetMonthCmd =>
           _getMonthCmd ?? (_getMonthCmd = new DelegateCommand(() => CurrentHour = DateTime.Now.ToString("MMMM")).ObservesCanExecute(() => IsCanExecute));

        public GetMonthTabVM(IAppCmds appcmds)
        {
            _appCmds = appcmds;
            //给复合命令GetCurrentAllTimeCommand注册子命令GetMonthCmd
            _appCmds.GetCurrentAllTimeCommand.RegisterCommand(GetMonthCmd);
        }
    }
}