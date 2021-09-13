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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFTask3._3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void VisualCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            PaintBox.Fill = new VisualBrush(panel);
        }

        private void LinearCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            PaintBox.Fill = new LinearGradientBrush(Colors.Black, Colors.White, 0);
        }

        private void RadialCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            PaintBox.Fill = new RadialGradientBrush(Colors.Black, Colors.White);
        }

        private void ImageCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            PaintBox.Fill = new ImageBrush(new BitmapImage(new Uri(@"https://www.google.com/images/branding/googlelogo/1x/googlelogo_color_272x92dp.png")));
        }
    }
}
