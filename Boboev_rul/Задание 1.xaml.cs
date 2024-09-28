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
using System.Numerics;

namespace Boboev_rul
{
    /// <summary>
    /// Логика взаимодействия для Задание_1.xaml
    /// </summary>
    public partial class Задание_1 : Window
    {
        public Задание_1()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e, ListBox List )
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e, TextBox textBox)
        {
 
             
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();
            string s = textbox.Text;
            int N = Convert.ToInt32(s);
            if (N <= 1000)
            {


                listBox1.Items.Add($"Число N= {N}");
                BigInteger result = BigInteger.Pow(N, N);
                listBox1.Items.Add($"Квадрат N= {result}");

                string resultString = result.ToString();

                int[] count = new int[10];

                foreach (char c in resultString)
                {
                    if (c >= '0' && c <= '9')
                    {
                        int k = Convert.ToInt32(c.ToString());
                        count[k] = count[k] + 1;
                    }
                }

                for (int i = 0; i < 10; i++)
                {
                    listBox1.Items.Add($"Цифра {i} встречается {count[i]} раз");
                }
            }
            else
            {
                listBox1.Items.Add("Число должно быть меньше 1000");
            }
        }
    }
  }
 