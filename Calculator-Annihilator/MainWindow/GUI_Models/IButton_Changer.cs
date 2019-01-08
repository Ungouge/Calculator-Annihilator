using System;
using System.Windows;

namespace Calculator_Annihilator
{
    /// <summary>
    /// Defines an object that contains button click events for exchanging specialised buttons 
    /// for difrent calculation methods.
    /// </summary>
    internal interface IButton_Changer
    {
        void Button_Open_Bracket_Click(object sender, RoutedEventArgs e);

        void Button_Close_Bracket_Click(object sender, RoutedEventArgs e);

        void Button_Change_Sign_Click(object sender, RoutedEventArgs e);

        void Button_Invert_Number_Click(object sender, RoutedEventArgs e);

        void Set_Open_Bracket_Or_Change_Sign_Button();

        void Set_Close_Bracket_Or_Invert_Number_Button();
    }
}
