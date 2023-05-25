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
using Library;

namespace forlibrary
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

        public class first
        {
            public DateTimeOffset Date { get; set; }
            public int TemperatureCelsius { get; set; }
            public string? Summary { get; set; }
        }
        public class second
        {
            public DateTimeOffset Date { get; set; }
            public int TemperatureCelsius { get; set; }
            public string? Summary { get; set; }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var a = new first
            {
                Summary = "работает"
            };
            Class1.JasonIn(a);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<second> item = new List<second> { };
            var weatherForecast = Class1.JasonOut<second>();
            item.Add(weatherForecast);
            Grid.ItemsSource = item;
        }
    }
}
