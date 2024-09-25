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

namespace CherkovaV_laba1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(Label1.Text);
            int day = (a % 4 == 0 && a % 100 != 0 || a % 400 == 0) ? 366 : 365;
            Label2.Text = Convert.ToString(day);
         
        }

        private void BattonExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow windowBeggin = new MainWindow();
            windowBeggin.Show();
            Hide();
        }
    }
}
