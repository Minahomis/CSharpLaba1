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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void BattonExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow windowBeggin = new MainWindow();
            windowBeggin.Show();
            Hide();
        }

        private void BattonResult_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string str = TextBoxArray.Text.Replace(" ", string.Empty);
                //int[] array = str.Split(',').Select(n => Convert.ToInt32(n)).ToArray();
                string[] strArray = str.Split(',');

                //Ввод массива int
                int[] array = new int[strArray.Length];
                for (int i = 0; i < strArray.Length; i++)
                {
                    int a = Convert.ToInt32(strArray[i]);
                    array[i] = a;
                }
                //Поиск Максимального элемента
                int max = 0;
                int number;
                for (int i = 0; i < array.Length; i++)
                {
                    number = array[i];
                    if (number > max)
                    {
                        max = number;
                    }
                }
                //Test.Text = max.ToString();//Test
                // Поиск двух чисел, сумма которых максимально приближена к Max
                int indexSave1 = 0;
                int indexSave2 = 0;
                int closestSum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        int sum = (array[i] + array[j]);
                        if (sum <= max && sum > closestSum)
                        {
                            closestSum = sum;
                            indexSave1 = i;
                            indexSave2 = j;
                        }
                    }
                }
                Test.Text = indexSave1.ToString();
                Test.Text += ", ";
                Test.Text += indexSave2.ToString();
                Test.Text += ", ";
                Test.Text += closestSum.ToString();
                //Меняем местами числа под индексом indexSave1 и indexSave2
                if (indexSave1 != -1 && indexSave2 != -1)
                {
                    int temp = array[indexSave1];
                    array[indexSave1] = array[indexSave2];
                    array[indexSave2] = temp;
                }

                //Вывод массива
                for (int i = 0; i < array.Length; i++)
                {
                    TextBoxNewArray.Text += Convert.ToString(array[i]);
                    if (i < array.Length - 1)
                        TextBoxNewArray.Text += ", ";
                    else
                        TextBoxNewArray.Text += ".";
                }
            }
            catch { MessageBox.Show("Неккоретный ввод!"); }

        }
    }
}
