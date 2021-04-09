using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Windows.Input;

namespace Wp.WpfDemo.UIL.TestLiveChart.ViewModels.Windows
{
    public class Window1VM : ViewModelBase
    {
        #region 属性、字段

        #region 统计

        private int _treeeCount;

        /// <summary>
        /// 当日经手树总数
        /// </summary>
        public int TreeCount { get { return _treeeCount; } set { _treeeCount = value; RaisePropertyChanged(); } }

        private int _productCount;

        /// <summary>
        /// 已清洗产品总数
        /// </summary>
        public int ProductCount { get { return _productCount; } set { _productCount = value; RaisePropertyChanged(); } }

        private ChartValues<int> _unqualifiedProductCount;

        /// <summary>
        /// 损耗产品总数
        /// </summary>
        public ChartValues<int> UnqualifiedProductCount { get { return _unqualifiedProductCount; } set { _unqualifiedProductCount = value; RaisePropertyChanged(); } }

        private ChartValues<int> _qualifiedProductCount;

        /// <summary>
        /// 正常产品总数
        /// </summary>
        public ChartValues<int> QualifiedProductCount { get { return _qualifiedProductCount; } set { _qualifiedProductCount = value; RaisePropertyChanged(); } }

        public Func<ChartPoint, string> PointLabel { get; set; }

        #endregion 统计

        public SeriesCollection SeriesCollection { get; set; }

        #region 命令

        public ICommand TestCmd => new RelayCommand(() =>
        {
            //Group.Success("申请转运车拉走！", "Msg");
        });

        #endregion 命令

        #endregion 属性、字段

        #region 方法

        public Window1VM()
        {
            UnqualifiedProductCount = new ChartValues<int>() { 15 };
            //UnqualifiedProductCount.Add(12);
            QualifiedProductCount = new ChartValues<int>() { 33 };
            //QualifiedProductCount.Add(30);
            PointLabel = chartPoint => $"{chartPoint.Y}";
            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<double> { 3, 5, 7, 4 }
                },
                 new ColumnSeries
                {
                    Values = new ChartValues<decimal> { 5, 6, 2, 7 }
                }
            };
        }

        #endregion 方法
    }
}