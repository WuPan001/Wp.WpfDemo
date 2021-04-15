using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wp.WpfDemo.UIL.TestPrism.Interfaces;

namespace Wp.WpfDemo.UIL.TestPrism.ViewModels.UserControls
{
    internal class GetYearTabVM
    {
        private IAppCmds _appCmds;
        private bool _isCanExecute;

        public bool IsCanExecute
        {
            get { return _isCanExecute; }
            set { _isCanExecute = value; }
        }

        private string _currentYear;

        public string CurrentYear
        {
            get { return _currentYear; }
            set { _currentYear = value; }
        }

        private DelegateCommand _getYearCmd;

        public DelegateCommand GetYearCmd =>
           _getYearCmd ?? (_getYearCmd = new DelegateCommand(() => CurrentYear = DateTime.Now.ToString("yyyy")).ObservesCanExecute(() => IsCanExecute));

        public GetYearTabVM(IAppCmds appcmds)
        {
            _appCmds = appcmds;
            //给复合命令GetCurrentAllTimeCommand注册子命令GetYearCmd
            _appCmds.GetCurrentAllTimeCommand.RegisterCommand(GetYearCmd);
        }
    }
}