﻿using ModernUI.Toolkit.Data.Charting.Charts.Series;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace Wp.WpfDemo.UIL.TestMetroModernUI
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<NameValueItem> items = new List<NameValueItem>();
            items.Add(new NameValueItem() { Name = "Test1", Value = 40 });
            items.Add(new NameValueItem() { Name = "Test2", Value = 50 });
            items.Add(new NameValueItem() { Name = "Test3", Value = 20 });
            items.Add(new NameValueItem() { Name = "Test4", Value = 10 });
            items.Add(new NameValueItem() { Name = "Test5", Value = 100 });

            ((ColumnSeries)Chart.Series[0]).ItemsSource = items;
            ((BarSeries)BarChart.Series[0]).ItemsSource = items;
            ((LineSeries)LineChart.Series[0]).ItemsSource = items;
            ((ColumnSeries)MixedChart.Series[0]).ItemsSource = items;
            ((LineSeries)MixedChart.Series[1]).ItemsSource = items;
            ((AreaSeries)AreaChart.Series[0]).ItemsSource = items;
            ((BubbleSeries)BubbleChart.Series[0]).ItemsSource = items;
            ((ScatterSeries)ScatteredChart.Series[0]).ItemsSource = items;
        }

        public class NameValueItem
        {
            private string _name;

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            private int _value;

            public int Value
            {
                get { return _value; }
                set { _value = value; }
            }

            public NameValueItem()
            {
            }
        }
    }
}