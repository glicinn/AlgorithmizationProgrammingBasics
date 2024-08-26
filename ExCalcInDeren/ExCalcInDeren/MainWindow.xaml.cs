using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace ExCalcInDeren
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private char op;
        private double a, b;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OneButton_Click(object sender, RoutedEventArgs e)
        {
            Itog.Text += '1';
        }

        private void SecondButton_Click(object sender, RoutedEventArgs e)
        {
            Itog.Text += '2';
        }

        private void ThreeButton_Click(object sender, RoutedEventArgs e)
        {
            Itog.Text += '3';
        }

        private void FourButton_Click(object sender, RoutedEventArgs e)
        {
            Itog.Text += '4';
        }

        private void FiveButton_Click(object sender, RoutedEventArgs e)
        {
            Itog.Text += '5';
        }

        private void SixButton_Click(object sender, RoutedEventArgs e)
        {
            Itog.Text += '6';
        }

        private void SevenButton_Click(object sender, RoutedEventArgs e)
        {
            Itog.Text += '7';
        }

        private void EighButton_Click(object sender, RoutedEventArgs e)
        {
            Itog.Text += '8';
        }

        private void NineButton_Click(object sender, RoutedEventArgs e)
        {
            Itog.Text += '9';
        }

        private void ZeroButton_Click(object sender, RoutedEventArgs e)
        {
            Itog.Text += '0';
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            if (Itog.Text != "")
            {
                op = '+';
                a = double.Parse(Itog.Text, CultureInfo.InvariantCulture.NumberFormat);
                Itog.Text = "";
            }
            else
            {
                return;
            }
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            if (Itog.Text != "")
            {
                op = '-';
                a = double.Parse(Itog.Text, CultureInfo.InvariantCulture.NumberFormat);
                Itog.Text = "";
            }
            else
            {
                return;
            }
        }

        private void MultButton_Click(object sender, RoutedEventArgs e)
        {
            if (Itog.Text != "")
            {
                op = '*';
                a = double.Parse(Itog.Text, CultureInfo.InvariantCulture.NumberFormat);
                Itog.Text = "";
            }
            else
            {
                return;
            }
        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            if (Itog.Text != "")
            {
                op = '/';
                a = double.Parse(Itog.Text, CultureInfo.InvariantCulture.NumberFormat);
                Itog.Text = "";
            }
            else
            {
                return;
            }
        }

        private void PointButton_Click(object sender, RoutedEventArgs e)
        {
            if (Itog.Text != "")
                Itog.Text += ',';
            else
                return;
        }

        private void CButton_Click(object sender, RoutedEventArgs e)
        {
            Itog.Text = "";
            Itog.Tag = "";
        }

        private void KvadButton_Click(object sender, RoutedEventArgs e)
        {
            if (Itog.Text != "")
            {
                double n;
                n = Convert.ToDouble(Itog.Text) * Convert.ToDouble(Itog.Text);
                Itog.Text = Convert.ToString(n);
            }
            else
            {
                return;
            }
        }

        private void FactButton_Click(object sender, RoutedEventArgs e)
        {
            if (Itog.Text != "")
            {
                double number, factorial = 1;
                number = Convert.ToDouble(Itog.Text);
                for (double i = number; i >= 2; i--)
                {
                    factorial *= i;
                }
                Itog.Text = Convert.ToString(factorial);
            }
            else
            {
                return;
            }
        }

        private void KorenButton_Click(object sender, RoutedEventArgs e)
        {
            if (Itog.Text != "")
            {
                double x;
                x = Convert.ToDouble(Itog.Text);
                Itog.Text = Convert.ToString(Math.Sqrt(x));
            }
            else
            {
                return;
            }
        }



        private void LogButton_Click(object sender, RoutedEventArgs e)
        {
            if (Itog.Text != "")
            {
                double log;
                log = Convert.ToDouble(Itog.Text);
                Itog.Text = Convert.ToString(Math.Log10(log));
            }
            else
            {
                return;
            }
        }

        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            if (Itog.Text != "")
            {
                Itog.Text = Itog.Text.Remove(Itog.Text.Length - 1, 1);
            }
            else
            {
                return;
            }
        }

        private void ZamZButton_Click(object sender, RoutedEventArgs e)
        {
            if (Itog.Text != "")
            {
                if (Itog.Text[0] == '-')
                {
                    Itog.Text = Itog.Text.Remove(0, 1);
                }
                else
                {
                    Itog.Text = '-' + Itog.Text;
                }
            }
            else
            {
                return;
            }
        }

        private void KubButton_Click(object sender, RoutedEventArgs e)
        {
            if (Itog.Text != "")
            {
                double t;
                t = Convert.ToDouble(Itog.Text) * Convert.ToDouble(Itog.Text) * Convert.ToDouble(Itog.Text);
                Itog.Text = Convert.ToString(t);
            }
            else
            {
                return;
            }
        }
      


        private void sinButton_Click(object sender, RoutedEventArgs e)
        {
            if (Itog.Text != "")
            {
                double s;
                s = Convert.ToDouble(Itog.Text);
                Itog.Text = Convert.ToString(Math.Sin(s));
            }
            else
            {
                return;
            }
        }

        private void tanButton_Click(object sender, RoutedEventArgs e)
        {
            if (Itog.Text != "")
            {
                double t;
                t = Convert.ToDouble(Itog.Text);
                Itog.Text = Convert.ToString(Math.Tan(t));
            }
            else
            {
                return;
            }
        }

        private void cosButton_Click(object sender, RoutedEventArgs e)
        {
            if (Itog.Text != "")
            {
                double c;
                c = Convert.ToDouble(Itog.Text);
                Itog.Text = Convert.ToString(Math.Cos(c));
            }
            else
            {
                return;
            }
        }



        private void RavnoButton_Click(object sender, RoutedEventArgs e)
        {
            if (Itog.Text != "")
            {
                b = double.Parse(Itog.Text, CultureInfo.InvariantCulture.NumberFormat);

                if (op == '+')
                {
                    Itog.Text = (a + b).ToString();
                    a += b;
                }
                else if (op == '-')
                {
                    Itog.Text = (a - b).ToString();
                    a -= b;
                }
                else if (op == '*')
                {
                    Itog.Text = (a * b).ToString();
                    a *= b;
                }
                else if (op == '/')
                {
                    if (b != 0)
                    {
                        Itog.Text = (a / b).ToString();
                        a /= b;
                    }
                    else
                    {
                        MessageBox.Show("Правила математики запрещают делить на 0! ");
                        Itog.Text = "";
                    }

                }
                else if (op == '%')
                {
                    if (b != 0)
                    {
                        Itog.Text = (a % b).ToString();
                        a %= b;
                    }
                    else
                    {
                        MessageBox.Show("Правила математики запрещают делить на 0!");
                        Itog.Text = "";
                    }
                }
            }
            else
            {
                return;
            }


        }

    }
}

