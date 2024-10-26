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

namespace ProgrammingBase_Iwanov_Tatymov
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

        //Вывод суммы всех чисел между числами А и В
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            int A, B;
            if (int.TryParse(NumA.Text, out A) && int.TryParse(NumB.Text, out B))
            {
                int sum = 0;
                for (int i = A + 1; i < B; i++)
                {
                    sum += i;
                }
                textLabel.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Введите корректные значения A и B", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //Вывод только нечетных чисел между числами А и В
        private void Button1_1_Click(object sender, RoutedEventArgs e)
        {
            int A, B;
            if (int.TryParse(NumA.Text, out A) && int.TryParse(NumB.Text, out B))
            {
                string oddNumbers = "";
                for (int i = A + 1; i < B; i++)
                {
                    if (i % 2 != 0)
                    {
                        oddNumbers += i + " ";
                    }
                }
                textLabel.Text = oddNumbers.ToString();
            }
            else
            {
                MessageBox.Show("Введите корректные значения A и B", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //Квадраты чисел от А до В
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            int A, B;
            if (int.TryParse(NumA.Text, out A) && int.TryParse(NumB.Text, out B))
            {
                for (int i = A; i <= B; i++)
                {
                    int square = i * i;
                    MessageBox.Show($"Квадрат числа {i} равен {square}");
                }
            }
            else
            {
                MessageBox.Show("Введите корректные значения A и B", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //Сумма всех чисел между А и В, включая их самих
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            int A, B;
            if (int.TryParse(NumA.Text, out A) && int.TryParse(NumB.Text, out B))
            {
                int sum = 0;

                for (int i = 1; i <= B; i++)
                {
                    sum += i;
                }

                textLabel.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Введено некорректное значение B", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //Расчёт начисление Премии, в зависимости от Выслуги Лет
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double salary = Convert.ToDouble(ZPCount.Text);
                int yearsOfService = Convert.ToInt32(YearAgo.Text);

                double prize = PrizeCalculate(salary, yearsOfService);
                textLabel1.Text = $"{prize:C}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные значения.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private double PrizeCalculate(double salary, int yearsOfService)
        {
            double prizePercentage;

            if (yearsOfService < 5)
            {
                prizePercentage = 0.10;
            }
            else if (yearsOfService < 10)
            {
                prizePercentage = 0.15;
            }
            else if (yearsOfService < 15)
            {
                prizePercentage = 0.25;
            }
            else if (yearsOfService < 20)
            {
                prizePercentage = 0.35;
            }
            else if (yearsOfService < 25)
            {
                prizePercentage = 0.45;
            }
            else
            {
                prizePercentage = 0.50;
            }

            return salary * prizePercentage;
        }
    }
}
