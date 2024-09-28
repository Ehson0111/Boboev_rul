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

namespace Boboev_rul
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

        private void FrmMain_ContentRendered(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Задание_1 Open = new Задание_1();
            Open.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Задание_2 Open = new Задание_2();
            Open.Show();
        }

        private void Task_4_Click(object sender, RoutedEventArgs e)
        {
            Задание_4 Open = new Задание_4();
            Open.Show();
        }

        private void Task_5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Task_3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Task_5_Click_1(object sender, RoutedEventArgs e)
        {
            Задание_5 Open = new Задание_5();
            Open.Show();
        }

        private void Task_3_Click_1(object sender, RoutedEventArgs e)
        {
            Задание_3 Open = new Задание_3();
            Open.Show();
        }
    }
}
