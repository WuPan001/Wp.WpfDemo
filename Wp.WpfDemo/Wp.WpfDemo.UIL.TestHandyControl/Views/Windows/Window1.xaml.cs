using HandyControl.Controls;
using System;

namespace Wp.WpfDemo.UIL.TestHandyControl.Views.Windows
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : System.Windows.Window
    {
        public Window1()
        {
            InitializeComponent();
            //new ImageBrowser(new Uri(@"pack://application:,,,/Resources/Naruto0.jpg")).Show();
            CoverFlowMain.AddRange(new[]
             {
                new Uri(@"pack://application:,,,/Resources/Naruto0.jpg"),
                new Uri(@"pack://application:,,,/Resources/Naruto1.jpg"),
                new Uri(@"pack://application:,,,/Resources/Naruto2.jpg"),
                new Uri(@"pack://application:,,,/Resources/Naruto3.jpg"),
                new Uri(@"pack://application:,,,/Resources/Naruto4.jpg"),
                new Uri(@"pack://application:,,,/Resources/Naruto5.jpg"),
                new Uri(@"pack://application:,,,/Resources/Naruto6.jpg"),
            });
            CoverFlowMain.JumpTo(2);
        }

        private void AnimationPath_Completed(object sender, EventArgs e)
        {
            (sender as AnimationPath).IsPlaying = false;
            Console.WriteLine("1212");
        }

        private void StackPanel_Completed(object sender, System.Windows.RoutedEventArgs e)
        {
        }
    }
}