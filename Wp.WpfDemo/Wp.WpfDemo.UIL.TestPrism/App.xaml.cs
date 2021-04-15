using Prism.Unity;
using Prism.Ioc;
using System.Windows;
using Prism.Modularity;
using Wp.WpfDemo.UIL.TestPrism.Interfaces;
using Wp.WpfDemo.UIL.TestPrism.ViewModels;
using Prism.Mvvm;
using System.Reflection;
using System;

namespace Wp.WpfDemo.UIL.TestPrism
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    //public partial class App : Application
    //{
    //}
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        //通过IOC容器注册IApplicationCommands为单例
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppCmds, AppCmds>();
        }

        //注册子窗体模块
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            //moduleCatalog.AddModule<CommandSample.CommandSampleMoudle>();
        }

        //配置规则
        //protected override void ConfigureViewModelLocator()
        //{
        //    base.ConfigureViewModelLocator();
        //    ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver((viewType) =>
        //    {
        //        var viewName = viewType.FullName.Replace(".Viewsb.", ".ViewModelsa.OhMyGod.");
        //        var viewAssemblyName = viewType.GetTypeInfo().Assembly.FullName;
        //        var viewModelName = $"{viewName}Test, {viewAssemblyName}";
        //        return Type.GetType(viewModelName);
        //    });
        //}
    }
}