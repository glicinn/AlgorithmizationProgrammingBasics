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
using Word = Microsoft.Office.Interop.Word;

namespace ExMagDeren
{
    /// <summary>
    /// Логика взаимодействия для Check.xaml
    /// </summary>
    public partial class Check : System.Windows.Window

    {

        public Check()
        {
            InitializeComponent();
            Sum.Text = App.at_cost.ToString();
            for (int i = 0; i < App.in_basket.Count; i++)
            {
                gods.Text = gods.Text + "   " + App.in_basket[i];
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Word.Application app = new Word.Application();
            Word.Document doc = app.Documents.Add();
            doc.Paragraphs[1].Range.Text = this.gods.Text;
            app.Visible = true;
        }
    }
}
