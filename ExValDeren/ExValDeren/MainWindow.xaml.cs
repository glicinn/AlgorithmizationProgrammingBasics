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

namespace ExValDeren
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

        private void Converter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (L1.Text == "₽")
                {
                    if (L2.Text == "₽")
                    {
                        T2.Text = T1.Text;
                    }
                    else if (L2.Text == "$")
                    {
                        int a = Convert.ToInt32(T1.Text);
                        T2.Text = $"{a / 55}";
                    }
                    else if (L2.Text == "€")
                    {
                        int a = Convert.ToInt32(T1.Text);
                        T2.Text = $"{a / 58}";
                    }
                }
                else if (L1.Text == "$")
                {
                    if (L2.Text == "₽")
                    {
                        int a = Convert.ToInt32(T1.Text);
                        T2.Text = $"{a * 55}";
                    }
                    else if (L2.Text == "$")
                    {
                        T2.Text = T1.Text;
                    }
                    else if (L2.Text == "€")
                    {
                        int a = Convert.ToInt32(T1.Text);
                        T2.Text = $"{a * 0.8}";
                    }
                }
                else if (L1.Text == "€")
                {
                    if (L2.Text == "₽")
                    {
                        int a = Convert.ToInt32(T1.Text);
                        T2.Text = $"{a * 58}";
                    }
                    else if (L2.Text == "$")
                    {
                        int a = Convert.ToInt32(T1.Text);
                        T2.Text = $"{a / 0.8}";
                    }
                    else if (L2.Text == "€")
                    {
                        T2.Text = T1.Text;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неверный синтаксис суммы!");
            }
        }
    }
}
