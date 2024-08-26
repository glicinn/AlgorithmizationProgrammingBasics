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
using System.Windows.Shapes;

namespace ExSkladDeren
{
    /// <summary>
    /// Логика взаимодействия для Kat.xaml
    /// </summary>
    public partial class Kat : Window
    {
        public Kat()
        {
            InitializeComponent();
        }

        private List<string> AuthorList = new List<string>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AuthorList.Add(cat.Text);
            MessageBox.Show("Категория добавлена!");
            cat.Text = string.Empty;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(AuthorList);
            main.Show();
            this.Close();
        }

        public Kat(List<string> transfer) : this()
        {
            AuthorList = transfer;
        }
    }
}
