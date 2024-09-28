using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    public partial class Задание_3 : Window
    {
        public Задание_3()
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Random rn = new Random();
            try
            {
                int N = Convert.ToInt32(text1.Text);

                int[] s = new int[N];
                for (int i = 0; i < N; i++)
                {
                    s[i] = rn.Next(-10, 10);
                }
                string s1 = " ";
                for (int i = 0; i < s.Length; i++)
                {

                    s1 = s1 + " " + Convert.ToString(s[i]);
                }
                int[] k = new int[N];

                for (int i = 0; i < s.Length; i++)
                {
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (s[i] == s[j])
                        {
                            k[i]++;

                        }
                    }
                }


                int max = k[0];
                int index = 0;

                for (int i = 1; i < k.Length; i++)
                {
                    if (k[i] > max)
                    {
                        max = k[i];
                        index = i;
                    }
                }
                textblock1.Text = s1;

                textblock2.Text = $"Максимальное количество одинаковых элементов: {max} для элемента {s[index]}";

            }
            catch (Exception)
            {

                textblock1.Text = $"Неверный формат ввода";

            }

        }

    }
    }
