using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Wp.WpfDemo.UIL.TestLiveChart.ViewModels.Windows;

namespace Wp.WpfDemo.UIL.TestLiveChart.Views.Windows
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public SeriesCollection SeriesCollection { get; set; }

        public Window1()
        {
            InitializeComponent();
            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint > {new ObservablePoint (12.3,22),new ObservablePoint (32.3,2.3432),new ObservablePoint (32.3,12),new ObservablePoint (133.3,2.2)},LineSmoothness=0
                },
                 new ColumnSeries
                {
                    Values = new ChartValues<decimal> { 5, 6, 2, 7 }
                },
            };
            //DataContext = this;
            DataContext = new Window1VM();
        }
    }
}