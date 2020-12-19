using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using HandyControl.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wp.Helpers;
using Wp.WpfDemo.Model.Entities.Assembly;
using Wp.WpfDemo.Model.Enums;

namespace Wp.WpfDemo.UIL.ViewModels.Pages
{
    public class HomePageVM : ViewModelBase
    {
        private ObservableCollection<AssemblySteperInfo> _steperItemInfo = new ObservableCollection<AssemblySteperInfo>();

        /// <summary>
        /// 步骤条信息
        /// </summary>
        public ObservableCollection<AssemblySteperInfo> SteperItemInfo { get { return _steperItemInfo; } set { _steperItemInfo = value; RaisePropertyChanged(); } }

        public ICommand StepperTestCmd => new RelayCommand(() =>
        {
            var temp = EnumHelper.GetEnumItems<EAssemblyStatus>();
            foreach (var item in temp)
            {
                var test = new AssemblySteperInfo() { };
                test.RFID = "RFID1234567890";
                test.Status = item;
                test.SteperItemInfo.Add(new AssemblySteperItemInfo() { FirstLevelTitle = "Title11", SecondLevelTitle = "Title12", Details = new ObservableCollection<string>() { "Detail1", "Detail2", "Detail3" } });
                test.SteperItemInfo.Add(new AssemblySteperItemInfo() { FirstLevelTitle = "Title21", SecondLevelTitle = "Title22", Details = new ObservableCollection<string>() { "Detail1", "Detail2", "Detail3" } });
                test.SteperItemInfo.Add(new AssemblySteperItemInfo() { FirstLevelTitle = "Title31", SecondLevelTitle = "Title32", Details = new ObservableCollection<string>() { "Detail1", "Detail2", "Detail3" } });
                test.SteperItemInfo.Add(new AssemblySteperItemInfo() { FirstLevelTitle = "Title41", SecondLevelTitle = "Title42", Details = new ObservableCollection<string>() { "Detail1", "Detail2", "Detail3" } });
                SteperItemInfo.Add(test);
            }
        });

        /// <summary>
        /// 折叠所有项命令
        /// </summary>
        public ICommand FoldExpanderCmd => new RelayCommand(() =>
        {
            foreach (var item in SteperItemInfo)
            {
                item.IsExpand = false;
            }
        });

        /// <summary>
        /// ScrollViewToTop命令
        /// </summary>
        public ICommand ScrollViewToTopCmd => new RelayCommand<ScrollViewer>(s => s.ScrollToTop());

        public ICommand NextStepCmd = new RelayCommand<StepBar>(s =>
        {
            s.Next();
        });
    }
}