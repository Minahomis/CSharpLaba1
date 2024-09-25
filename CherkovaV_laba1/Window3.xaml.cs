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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BattonExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow windowBeggin = new MainWindow();
            windowBeggin.Show();
            Hide();
        }

        private void ButtonGo_Click(object sender, RoutedEventArgs e)
        {
            //Дан массив ненулевых целых чисел размера N.
            //Проверить, чередуются ли в нем четные и нечетные числа.
            //Если чередуются, то вывести 0, если нет, то вывести номер
            //первого элемента, нарушающего закономерность.
            string[] strArray = TextBox1.Text.Split(' ');
            int[] array = new int[strArray.Length];

            for (int i = 0; i < strArray.Length; i++)
            {
                int a = int.Parse(strArray[i]);
                array[i] = a;
            }
            int result = 0;
            int evenOrOdd = 0; //первое число если чётное - 0, если не чётное - 1
            if (array[0] % 2 == 0)
            {
                for (int i = 1; i < strArray.Length; i += 2) { array[i] += 1; }
            }
            else
            {
                evenOrOdd = 1;
                for (int i = 0; i < strArray.Length; i += 2) { array[i] += 1; }
            }

            /*for (int i = 0; i < array.Length; i++)
            {
                if (array[0] % 2 == 0)
                {
                    if (i % 2 != 0) {
                        for (int j = 0; j < array.Length; j++) { array[i] += 1; }
                    }
                }
                else
                {
                    if (i % 2 == 0) {
                        for (int j = 0; j < array.Length; j++) { array[i] += 1; }
                    }
                }
                //В идеале будет четный массив array[i] % 2 == 0               
            }*/
            for(int i = 0; i <array.Length; i++)
            {
                if (array[i] % 2 != 0 && evenOrOdd == 1)
                {
                    result = array[i] - 1;
                    break;
                }
                else if (array[i] % 2 != 0 && evenOrOdd == 0)
                {
                    result = array[i];
                    break;
                }
            }

            TextBox2.Text = result.ToString();

        }
    }
}
