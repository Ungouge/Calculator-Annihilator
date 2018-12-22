using System;
using System.Windows;
using System.Windows.Controls;

namespace Calculator_Annihilator
{
    /// <summary>
    /// Class for setting features of passed button to function as close bracket or invert number button
    /// according to currently ussed calculation method.
    /// </summary>
    internal class Close_Bracket_Or_Invert_Number_Exchanger
    {
        /// <summary>
        /// Sets button features to function as close bracket or invert number button
        /// according to currently ussed calculation method.
        /// </summary>
        protected internal void Set_Close_Bracket_Or_Invert_Number_Button(Button Button, Calculation_Method Calculation_Method, IButton_Changer Buttons_Controller)
        {
            if (Calculation_Method == Calculation_Method.Complex)
            {
                Button.Content = ")";

                Button.Click += new RoutedEventHandler(Buttons_Controller.Button_Close_Bracket_Click);
            }
            else
            {
                Button.Content = "1/x";

                Button.Click += new RoutedEventHandler(Buttons_Controller.Button_Invert_Number_Click);
            }
        }
    }
}
