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
    /// Логика взаимодействия для Задание_5.xaml
    /// </summary>
    public partial class Задание_5 : Window
    {
        public Задание_5()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            int N1 = Convert.ToInt32(text.Text);
            int M = Convert.ToInt32(text1.Text);
            int[,] s = new int[N1, M];
            Random rm = new Random();
            var data = new List<List<int>>();
            for (int i = 0; i < N1; i++)
            {
                var row = new List<int>();
                for (int J = 0; J < M; J++)
                {
                    s[i, J] = rm.Next(-100, 100);
                    row.Add(s[i, J]);
                }
                data.Add(row);
            }
            // Привязка данных к ListView
            listView.ItemsSource = data;
            int n = 0;

            int[] tempArray = new int[M * N1];
            for (int i = 0; i < N1; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    tempArray[n] = s[i, j];
                    n++;
                }
            }
            Array.Sort(tempArray);
            int n1 = 0;
            Console.WriteLine("\n");

            var data1 = new List<List<int>>();
            for (int i = 0; i < N1; i++)
            {
                var row1= new List<int>();
                for (int j = 0; j < M; j++)
                { 
                    
                    s[i, j] = tempArray[n1];
                    n1++;
                    row1.Add(s[i, j]);
                }
                data1.Add(row1);
            }
            listView1.ItemsSource = data1;
            int n2 = 0;
            Array.Reverse(tempArray);
            Console.WriteLine("\n");
            var data2= new List<List<int>>();
            for (int i = 0; i < N1; i++)
            {
                var row1 = new List<int>();
                for (int j = 0; j < M; j++)
                {
                    s[i, j] = tempArray[n2];
                    n2++;
                    row1.Add(s[i, j]);
                }
                data2.Add(row1);

            }
            listView2.ItemsSource = data2;
            int max = s[0, 0];
            int min = s[0, 0];
            for (int i = 0; i < N1; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (max < s[i, j])
                    {
                        max = s[i, j];
                    }
                    if (min > s[i, j])
                    {
                        min = s[i, j];
                    }
                }
            }
            listbox.Items.Add("Минимальный элемент "+ max);
            listbox.Items.Add(" Максимальный элемент "+min);


            string s2 = "Сгенерировать массив размером M столбцов и N строк, содержащий числа от -10 до 10. Отобразить его пользователю. Отсортировать элементы в нем по возрастанию и по убыванию. Вывести результаты сортировки в двух таблицах. Найти максимальный и минимальный элементы массива";
            textbox.Text = s2;
        }

        private void text1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
