using System.Windows;
using System.Windows.Controls;

namespace Wp.WpfDemo.UIL.Views.Pages
{
    /// <summary>
    /// HomePage.xaml 的交互逻辑
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if ((bool)printDialog.ShowDialog())
            {
                printDialog.PrintVisual(TestPrinter, "打印测试");
            }
        }
    }
}