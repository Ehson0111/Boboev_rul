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

namespace Boboev_rul
{
    /// <summary>
    /// Логика взаимодействия для Задание_2.xaml
    /// </summary>
    public partial class Задание_2 : Window
    {
        public Задание_2()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string input = text.Text;

            char[] s = input.ToCharArray();
            bool odf = false;
            s[0] = char.ToUpper(s[0]);
            for (int i = 1; i < s.Length; i++)
            {
                if (char.IsWhiteSpace(s[i]) || (s[i] == ',') || (s[i] == '.') || (s[i] == '!') || (s[i] == '?'))
                {
                    odf = true;
                }
                else if (odf)
                {
                    s[i] = char.ToUpper(s[i]);
                    odf = false;
                }
                else
                {
                    s[i] = char.ToLower(s[i]);

                }  
            }

            string s1 = new string(s);
            textblock.Text = s1;
        }
    }
}
