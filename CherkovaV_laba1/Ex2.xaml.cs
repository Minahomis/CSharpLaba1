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
    /// Interaction logic for Ex2.xaml
    /// </summary>
    public partial class Ex2 : Window
    {
        public Ex2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FinalWorlds.Text = string.Empty;
            string strWorlds = Worlds.Text;
            string[] strArray = strWorlds.Split(' ');
            int countA;
            string[] newArrayWorlds = new string[strArray.Length];
            for (int i = 0; i < strArray.Length; i++) {
                countA = 0;
                string str = strArray[i];
                for (int j = 0; j < str.Length; j++) {
                    char c = str[j];
                    if (c == 'А' || c == 'а' || c == 'A' || c == 'a') {
                        countA++;
                    }
                }
                if (countA == 3) {
                    newArrayWorlds[i] = str;
                }

            }

            for (int i = 0; i < newArrayWorlds.Length; i++) {
                FinalWorlds.Text += newArrayWorlds[i];
                FinalWorlds.Text += " ";
            }


        }

        private void BattonExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow windowBeggin = new MainWindow();
            windowBeggin.Show();
            Hide();
        }
    }
}
