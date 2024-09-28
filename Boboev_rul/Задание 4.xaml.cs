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
    /// Логика взаимодействия для Задание_4.xaml
    /// </summary>
    public partial class Задание_4 : Window
    {
        public Задание_4()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string a = textBox.Text;
            string[] s = a.Split(' ');

            int[] list = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                list[i] = int.Parse(s[i]);
            }
            int totalSum = 0;
            foreach (int num in list)
            {
                totalSum += num;
            }

            int minSum = totalSum / 2;
            int maxSum = (int)(totalSum * 1.5 / 2);

            bool canDivide = false;
            int sum1 = 0;
            int sum2 = 0;
            int index = 0;

            for (int i = 0; i < list.Length; i++)
            {
                sum1 += list[i];
                if (sum1 >= minSum && sum1 <= maxSum)
                {
                    canDivide = true;
                    index = i + 1;
                    break;
                }
            }

            if (canDivide)
            {
                Console.Write("Первая часть: ");
                string ss = "Первая часть: ";
                for (int i = 0; i < index; i++)
                {
                    ss = ss + " " + Convert.ToString(list[i]);
                }
                textBoxLeft.Text = ss;
                string ss2 = "Вторая часть:  ";
                for (int i = index; i < list.Length; i++)
                {
                    ss2 = ss2 + " " + list[i];
                }
                textBox2.Text = ss2;
            }
            else
            {
                textBoxLeft.Text = "Невозможно разделить массив на две части с заданным условием.";
            }
        }
    }
}
