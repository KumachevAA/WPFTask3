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

namespace WPFTask3._2
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

        private List<Ellipse> points = new List<Ellipse>();

        private void Window_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DrawPoly.Points.Add(e.GetPosition(MainGrid));

                Ellipse ellipse = new Ellipse();
                MainGrid.Children.Add(ellipse);
                ellipse.Fill = Brushes.DarkRed;
                ellipse.Width = 15;
                ellipse.Height = 15;
                ellipse.HorizontalAlignment = HorizontalAlignment.Left;
                ellipse.VerticalAlignment = VerticalAlignment.Top;
                ellipse.RenderTransformOrigin = new Point(0.5, 0.5);
                ellipse.RenderTransform = new TranslateTransform(e.GetPosition(MainGrid).X - 7.5, e.GetPosition(MainGrid).Y - 7.5);
                points.Add(ellipse);
            }
            else if (e.ChangedButton == MouseButton.Right)
            {
                DrawPoly.Points.Clear();

                foreach(UIElement element in points)
                {
                    MainGrid.Children.Remove(element);
                }

                points.Clear();
            }
        }
    }
}
