using System;
using System.Windows;
using System.Windows.Controls;

namespace Calculator_Annihilator
{
    partial class Basic_Operations_Less_Than_Hexadecimal_System : UserControl
    {

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
            MainWindow.Button_Percent_Action();
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
            MainWindow.Insert_Text_Button_Actionn(MainWindow.Options.Comma_Type);
        }

        private void Button_Exponent_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Exponent_Button_Action();
        }
    }
}
