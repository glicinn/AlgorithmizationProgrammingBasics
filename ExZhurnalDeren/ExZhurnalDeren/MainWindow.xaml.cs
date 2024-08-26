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

namespace ExZhurnalDeren
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

        int ID = 1;
        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dgStudent.Items.Add(new Student { Id = ID++, SecName = tbSecName.Text, Name = tbName.Text, MidName = tbMidName.Text, Date = tbDate.Text, Mark = Convert.ToInt32(tbMark.Text) });
            }
            catch
            {
                MessageBox.Show("Оценка - не число!");
            }
        }

        public class Student
        {
            public int Id { get; set; }
            public string SecName { get; set; }
            public string Name { get; set; }
            public string MidName { get; set; }
            public string Date { get; set; }
            public int Mark { get; set; }
        }


        private void btDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dgStudent.Items.RemoveAt(dgStudent.SelectedIndex);
                ID--;
            }
            catch
            {
                MessageBox.Show("Строка не выбрана!");
            }
        }
    }
}
