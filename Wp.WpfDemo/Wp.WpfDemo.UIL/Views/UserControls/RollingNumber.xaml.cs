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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wp.WpfDemo.UIL.Views.UserControls
{
    /// <summary>
    /// RollingNumber.xaml 的交互逻辑
    /// </summary>
    public partial class RollingNumber : UserControl
    {
        private int Score = 264;

        public RollingNumber()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Score += 2;
            var target = Score.ToString().Select(c => int.Parse(c.ToString())).ToArray();
            var randomFactory = new Random();
            for (var i = 1; i <= 3; i++)
            {
                var animation = new DoubleAnimation()
                {
                    From = randomFactory.Next(-400, 1),
                    To = (target[i - 1] + 1) * (-40),
                    Duration = new Duration(TimeSpan.FromSeconds(2))
                };
                animation.EasingFunction = new CubicEase() { EasingMode = EasingMode.EaseOut };
                (FindName($"trans{i}") as TranslateTransform).BeginAnimation(TranslateTransform.YProperty, animation);
            }
        }
    }
}