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

namespace ExKNDeren
{
    /// <summary>
    /// Логика взаимодействия для Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        public Game()
        {
            InitializeComponent();
        }

        string hod = "✖";

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            if (hod == "✖")
            {
                b.Content = "✖";
                b.IsEnabled = false;
            }
            if (b1.Content != null && b2.Content != null && b3.Content != null && b4.Content != null && b5.Content != null && b6.Content != null && b7.Content != null && b8.Content != null && b9.Content != null)
            {
                checkwinner();
            }
            else
            {
                AITurn();
            }
            checkwinner();
        }

        private void checkwinner()
        {
            bool pob = false;
            if (b1.Content == "✖" && b2.Content == "✖" && b3.Content == "✖")
            {
                MessageBox.Show($"Победил ✖-игрок!");
                pob = true;
            }
            if (b4.Content == "✖" && b5.Content == "✖" && b6.Content == "✖")
            {
                MessageBox.Show($"Победил ✖-игрок!");
                pob = true;
            }
            if (b7.Content == "✖" && b8.Content == "✖" && b9.Content == "✖")
            {
                MessageBox.Show($"Победил ✖-игрок!");
                pob = true;
            }
            if (b1.Content == "✖" && b4.Content == "✖" && b7.Content == "✖")
            {
                MessageBox.Show($"Победил ✖-игрок!");
                pob = true;
            }
            if (b2.Content == "✖" && b5.Content == "✖" && b8.Content == "✖")
            {
                MessageBox.Show($"Победил ✖-игрок!");
                pob = true;
            }
            if (b3.Content == "✖" && b6.Content == "✖" && b9.Content == "✖")
            {
                MessageBox.Show($"Победил ✖-игрок!");
                pob = true;
            }
            if (b1.Content == "✖" && b5.Content == "✖" && b9.Content == "✖")
            {
                MessageBox.Show($"Победил ✖-игрок!");
                pob = true;
            }
            if (b3.Content == "✖" && b5.Content == "✖" && b7.Content == "✖")
            {
                MessageBox.Show($"Победил ✖-игрок!");
                pob = true;
            }

            if (b1.Content == "◯" && b2.Content == "◯" && b3.Content == "◯")
            {
                MessageBox.Show($"Победил ◯-игрок!");
                pob = true;
            }
            if (b4.Content == "◯" && b5.Content == "◯" && b6.Content == "◯")
            {
                MessageBox.Show($"Победил ◯-игрок!");
                pob = true;
            }
            if (b7.Content == "◯" && b8.Content == "◯" && b9.Content == "◯")
            {
                MessageBox.Show($"Победил ◯-игрок!");
                pob = true;
            }
            if (b1.Content == "◯" && b4.Content == "◯" && b7.Content == "◯")
            {
                MessageBox.Show($"Победил ◯-игрок!");
                pob = true;
            }
            if (b2.Content == "◯" && b5.Content == "◯" && b8.Content == "◯")
            {
                MessageBox.Show($"Победил ◯-игрок!");
                pob = true;
            }
            if (b3.Content == "◯" && b6.Content == "◯" && b9.Content == "◯")
            {
                MessageBox.Show($"Победил ◯-игрок!");
                pob = true;
            }
            if (b1.Content == "◯" && b5.Content == "◯" && b9.Content == "◯")
            {
                MessageBox.Show($"Победил ◯-игрок!");
                pob = true;
            }
            if (b3.Content == "◯" && b5.Content == "◯" && b7.Content == "◯")
            {
                MessageBox.Show($"Победил ◯-игрок!");
                pob = true;
            }
            if (pob == false && b1.Content != null && b2.Content != null && b3.Content != null && b4.Content != null && b5.Content != null && b6.Content != null && b7.Content != null && b8.Content != null && b9.Content != null)
            {

                MessageBox.Show("Ничья!");
            }
        }

        public void AITurn() //заполнение нолика
        {
            Button[] BArr = new Button[9];  //создаем массив
            BArr[0] = b1;
            BArr[1] = b2;
            BArr[2] = b3;
            BArr[3] = b4;
            BArr[4] = b5;
            BArr[5] = b6;
            BArr[6] = b7;
            BArr[7] = b8;
            BArr[8] = b9;
            bool ok = false;
            do
            {
                Random rand = new Random();
                int randed = rand.Next(0, 9);
                if (BArr[randed].Content == null && BArr[randed].IsEnabled) //если какое то место от 0 до 9 пусто, то туда мы пишем свой нолик
                {
                    BArr[randed].Content = "◯";
                    BArr[randed].IsEnabled = false;
                    ok = true;
                }
            }
            while (ok == false);
        }

        private void restart_Click(object sender, RoutedEventArgs e) // сброс
        {
            b1.Content = null; b1.IsEnabled = true;
            b2.Content = null; ; b2.IsEnabled = true;
            b3.Content = null; b3.IsEnabled = true;
            b4.Content = null; b4.IsEnabled = true;
            b5.Content = null; b5.IsEnabled = true;
            b6.Content = null; b6.IsEnabled = true;
            b7.Content = null; b7.IsEnabled = true;
            b8.Content = null; b8.IsEnabled = true;
            b9.Content = null; b9.IsEnabled = true;
        }

        private void Exit_Click(object sender, RoutedEventArgs e) //выход, закрытие окна
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
