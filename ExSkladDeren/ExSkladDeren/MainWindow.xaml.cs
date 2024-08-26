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

namespace ExSkladDeren
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lst.Items.Add("Bugatti" + ", Категория: Спорткар");
            lst.Items.Add("Audi" + ", Категория: Спорткар");
            lst.Items.Add("Marussia" + ", Категория: Спорткар");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lst.Items.Add(product.Text + ", Категория: " + category.SelectedValue);
            MessageBox.Show("Товар добавлен!");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lst.Items.RemoveAt(lst.SelectedIndex);
            MessageBox.Show("Товар удален!");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int i = lst.SelectedIndex;
            lst.Items.RemoveAt(i);
            lst.Items.Insert(i, product.Text + ", Категория: " + category.SelectedValue);
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (category.Items.Count == 0)
            {
                Kat cat = new Kat();
                cat.Show();
                this.Close();
            }
            else
            {
                List<string> temp = new List<string>();
                for (int i = 0; i < category.Items.Count; i++)
                {
                    temp.Add(category.Items.GetItemAt(i).ToString());
                    Kat cat = new Kat(temp);
                    cat.Show();
                    this.Close();
                }
            }
        }


        public MainWindow(List<string> AuthorList) : this()
        {
            if (category.ItemsSource == null)
            {
                category.ItemsSource = AuthorList;
            }
            else
            {
                category.ItemsSource = AuthorList;
            }
        }
    }
}
