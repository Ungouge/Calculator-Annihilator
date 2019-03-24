using System;
using System.Windows;

namespace Calculator_Annihilator
{
    partial class Basic_Operations_Less_Than_Decimal_System
    {
        private void Button_CE_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Button_CE_Action();
        }

        private void Button_Exponent_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Exponent_Button_Action();
        }

        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Button_Clear_Action();
        }

        private void Button_ANS_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Button_ANS_Action();
        }

        private void Button_Percent_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button_PlusSign_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Button_PlusSign_Action();
        }

        private void Button_MinuSing_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Button_MinuSing_Action();
        }

        private void Button_MultiplicationSing_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Button_MultiplicationSing_Action();
        }

        private void Button_DivisionSign_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Button_DivisionSign_Action();
        }

        private void Button_Equals_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Button_Equals_Action();
        }

        private void Button_Comma_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Number_Button_Action(',');
        }
    }
}
