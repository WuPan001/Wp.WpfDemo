using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using HandyControl.Controls;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Wp.Helpers.Helpers;
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

        private int testRadioButton;

        /// <summary>
        /// RadioButton测试
        /// </summary>
        public int TestRadioButton
        {
            get { return testRadioButton; }
            set { testRadioButton = value; RaisePropertyChanged(); }
        }

        private ObservableCollection<string> chips = new ObservableCollection<string>();

        public ObservableCollection<string> Chips
        {
            get { return chips; }
            set { chips = value; }
        }

        private string _time = 0.ToString();

        public string TestTime
        {
            get { return _time; }
            set { _time = value; RaisePropertyChanged(); }
        }

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
        public ICommand ScrollViewToTopCmd => new RelayCommand<System.Windows.Controls.ScrollViewer>(s => s.ScrollToTop());

        public ICommand NextStepCmd => new RelayCommand<StepBar>(s =>
        {
            s.Next();
        });

        public ICommand TestRadioButtonCmd => new RelayCommand(() =>
        {
            Console.WriteLine(testRadioButton);
        });

        public ICommand AddChipCmd => new RelayCommand<WrapPanel>(w =>
        {
            //Content = "James Willock"
            //                                 IsDeletable = "True"
            //                                 Background = "White"
            //                                 BorderBrush = "Black"
            //                                 BorderThickness = "3"
            //                                 IconBackground = "Red"
            //                                 x: Name = "ButtonsDemoChip"
            //                                 ToolTip = "Just a tool tip"
            //                                 DeleteToolTip = "Your friendly neighbour delete button" >
            //                < materialDesign:Chip.Icon >

            //                     < Image Source = "/Resources/Naruto0.jpg" ></ Image >

            //                  </ materialDesign:Chip.Icon >
            w.Children.Add(new Chip()
            {
                DeleteCommand = TestDeleteChipCmd,
                DeleteCommandParameter = new Binding() { RelativeSource = new RelativeSource() { Mode = RelativeSourceMode.Self } },
                Content = 1212112,
                IsDeletable = true,
                ToolTip = "Just a tool tip",
                DeleteToolTip = "Your friendly neighbour delete button",
                Icon = new Image() { Source = new BitmapImage(new Uri("pack://application:,,,/Resources/Naruto0.jpg")) }
            });
        });

        public ICommand DeleteChipCmd => new RelayCommand<Chip>(c =>
        {
            Console.WriteLine(c.Content);
        });

        public ICommand TestDeleteChipCmd => new RelayCommand<object>(c =>
        {
            if (c is null)
            {
                Console.WriteLine("null");
            }
            else
            {
                var cc = c as Chip;
                cc.Visibility = System.Windows.Visibility.Collapsed;
                Console.WriteLine(cc.Content);
            }
        });

        public ICommand AddTimeCmd => new RelayCommand(() => Console.WriteLine(TestTime = (Convert.ToInt32(TestTime) + 1).ToString()));
        public ICommand SubTimeCmd => new RelayCommand(() => Console.WriteLine(TestTime = (Convert.ToInt32(TestTime) - 1).ToString()));
    }
}