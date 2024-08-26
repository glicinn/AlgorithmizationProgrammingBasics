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

namespace ExMagDeren
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> list = new List<string>();
        List<int> prices = new List<int>();
        public MainWindow()
        {

            InitializeComponent();
            list.Add("Пиво светлое");
            prices.Add(50);
            list.Add("Пиво темное");
            prices.Add(60);
            list.Add("Пиво чешское");
            prices.Add(70);
            list.Add("Жигули");
            prices.Add(40);
            list.Add("Старый мельник");
            prices.Add(55);
            list.Add("Bud");
            prices.Add(62);
            list.Add("МЧС");
            prices.Add(200);
            goods.ItemsSource = list;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (goods.Text != "")
            {

                App.in_basket.Add(goods.Text + "  стоимость: " + g.Text);
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == goods.Text)
                    {

                        App.at_cost += prices[i];
                    }
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Check check = new Check();
            window.Close();
            check.Show();
        }

        private void goods_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == goods.SelectedItem.ToString())
                {
                    g.Text = prices[i].ToString();
                }
            }
        }
    }
}
