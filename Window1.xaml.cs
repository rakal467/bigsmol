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

namespace bigsmoll
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private Random random;
        private int dice1;
        private int dice2;

        public Window1()
        {
            InitializeComponent();
            random = new Random();
            NewGame();
        }
        private void RollDice()
        {
            dice1 = random.Next(1, 6); // Генерируем число от 1 до 6 для первого кубика
            dice2 = random.Next(1, 6); // Генерируем число от 1 до 6 для второго кубика
        }

        private void CheckGuess(int guess)
        {
            int sum = dice1 + dice2;
            if (guess == sum)
            {
                txtResult.Text = $"Поздравляем! Вы угадали: {sum}";
            }
            else
            {
                txtResult.Text = $"Упс! Вы проиграли. Сумма: {sum}";
            }
        }

        private void NewGame()
        {
           
            txtResult.Text = "";
            RollDice();
            UpdateSumLabel();
        }

        private void UpdateSumLabel()
        {
            sumLabel.Content = $"Сумма: {dice1 + dice2}";
        }

        private void MoreThanSeven_Click(object sender, RoutedEventArgs e)
        {
            CheckGuess(8); // Проверяем, была ли сумма более 7
        }

        private void LessThanSeven_Click(object sender, RoutedEventArgs e)
        {
            CheckGuess(6); // Проверяем, была ли сумма менее 7
        }

        private void EqualsSeven_Click(object sender, RoutedEventArgs e)
        {
            CheckGuess(7); // Проверяем, была ли сумма равна 7
        }

        private void RollDice_Click(object sender, RoutedEventArgs e)
        {
            NewGame();
        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            NewGame();
        }
    }
}

