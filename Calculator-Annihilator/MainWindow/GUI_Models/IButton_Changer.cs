using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator_Annihilator
{
    /// <summary>
    /// Defines an object that contains button click events for exchanging specialised buttons 
    /// for difrent calculation methods.
    /// </summary>
    interface IButton_Changer
    {
        void Button_Open_Bracket_Click(object sender, RoutedEventArgs e);

        void Button_Close_Bracket_Click(object sender, RoutedEventArgs e);

        void Button_Change_Sign_Click(object sender, RoutedEventArgs e);

        void Button_Invert_Number_Click(object sender, RoutedEventArgs e);
    }
}
