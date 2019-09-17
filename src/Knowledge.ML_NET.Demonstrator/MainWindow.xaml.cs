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
using Knowledge.ML_NET.Demonstrator.Digits;

namespace Knowledge.ML_NET.Demonstrator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            InitialControlOccurance.BorderThickness = new Thickness(10);

            var demoControl = new DemoControl
            {
                Width = 100,
                Height = MyCanvas.ActualHeight,
                BorderThickness = new Thickness(4),
                BorderBrush = new SolidColorBrush(Color.FromRgb(255, 0, 0)),
                Background = new SolidColorBrush(Color.FromRgb(0, 255, 0)),
                Margin = new Thickness(0,0,0,0)
            };
            MyCanvas.Children.Add(demoControl);
        }
    }
}
