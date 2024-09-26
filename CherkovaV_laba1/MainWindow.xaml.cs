using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CherkovaV_laba1
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

        private void bt_1_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            Hide();
        }

        private void bt_2_Click(object sender, RoutedEventArgs e)
        {
            Ex2 window2 = new Ex2();
            window2.Show();
            Hide();
        }

        private void bt_4_Click(object sender, RoutedEventArgs e)
        {
            Window2 window4 = new Window2();
            window4.Show();
            Hide();

        }

        private void bt_3_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
            Hide();
        }

        private void bt_5_Click(object sender, RoutedEventArgs e)
        {
            Window5 window5 = new Window5();
            window5.Show();
            Hide();
        }
    }
}