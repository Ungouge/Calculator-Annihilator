﻿using System;
using System.Windows;

namespace Calculator_Annihilator
{
    partial class Less_Than_Decimal_System
    {
        private void Button_0_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Number_Button_Action('0');
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Number_Button_Action('1');
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Number_Button_Action('2');
        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Number_Button_Action('3');
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Number_Button_Action('4');
        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Number_Button_Action('5');
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Number_Button_Action('6');
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Number_Button_Action('7');
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Number_Button_Action('8');
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Number_Button_Action('9');
        }

        private void Button_Comma_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Insert_Text_Button_Actionn(MainWindow.Options.Comma_Type);
        }

        private void Button_Exponent_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Exponent_Button_Action();
        }

        void IButton_Changer.Button_Open_Bracket_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MainWindow.Number_Button_Action('(');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void IButton_Changer.Button_Close_Bracket_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Number_Button_Action(')');
        }

        void IButton_Changer.Button_Change_Sign_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Button_Change_Sign_Action();
        }

        void IButton_Changer.Button_Invert_Number_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Button_Invert_Number_Action();
        }

        private void Button_BackSpace_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Button_BackSpace_Action();
        }
    }
}