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

namespace _20220924
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string instr = TX1.Text;
            for(int i = 65; i <= 90; i++)
            {
                char a = Convert.ToChar(i);
                int FQ = instr.Split(a).Length-1;
                if(FQ >0)
                    TB1.Text = TB1.Text + a + ":" + FQ + "\n";
            }
            for (int i = 97; i <= 122; i++)
            {
                char a = Convert.ToChar(i);
                int FQ = instr.Split(a).Length - 1;
                if (FQ > 0)
                    TB1.Text = TB1.Text + a + ":" + FQ + "\n";
            }
        }
    }
}
