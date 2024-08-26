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

namespace ExSystemDeren
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int temp = int.Parse(tb.Text);
            string opa = Convert.ToString(temp, 2);
            tb.Text = opa;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            int temp = int.Parse(tb.Text);
            string opa = Convert.ToString(temp, 8);
            tb.Text = opa;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            int temp = int.Parse(tb.Text);
            string opa = Convert.ToString(temp, 10);
            tb.Text = opa;
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            int temp = int.Parse(tb.Text);
            string opa = Convert.ToString(temp, 16);
            tb.Text = opa;
        }
    }
}
