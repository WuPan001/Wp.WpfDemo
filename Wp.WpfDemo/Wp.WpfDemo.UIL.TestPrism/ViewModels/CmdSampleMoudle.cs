using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wp.WpfDemo.UIL.TestPrism.ViewModels
{
    internal class CmdSampleMoudle : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            //var regionManager = containerProvider.Resolve<IRegionManager>();
            //IRegion region = regionManager.Regions["ContentRegion"];
            //var mainWindow = containerProvider.Resolve<MainWindow>();
            //(mainWindow.DataContext as MainWindowViewModel).Title = "GetYearTab";
            //region.Add(mainWindow);
            //var getMonthTab = containerProvider.Resolve<GetMonthDayTab>();
            //(getMonthTab.DataContext as GetMonthDayTabViewModel).Title = "GetMonthDayTab";
            //region.Add(getMonthTab);

            //var getHourTab = containerProvider.Resolve<GetHourTab>();
            //(getHourTab.DataContext as GetHourTabViewModel).Title = "GetHourTab";
            //region.Add(getHourTab);
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            throw new NotImplementedException();
        }
    }
}