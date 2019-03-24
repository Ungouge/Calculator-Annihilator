using System;
using System.Windows;
using System.Windows.Controls;
using Common_Library;

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
        protected internal void Set_Close_Bracket_Or_Invert_Number_Button(
            Button _Button, Calculation_Method Calculation_Method, IButton_Changer Buttons_Controller)
        {
            Remove_EventHandlers(_Button, Buttons_Controller);
            if (Calculation_Method == Calculation_Method.Complex)
            {
                _Button.Content = ")";

                Add_Close_Bracket_Button(_Button, Buttons_Controller);
            }
            else
            {
                _Button.Content = "1/x";

                Add_Invert_Number_Button(_Button, Buttons_Controller);
            }
        }

        private void Add_Invert_Number_Button(Button _Button, IButton_Changer Buttons_Controller)
        {
            _Button.Click += new RoutedEventHandler(Buttons_Controller.Button_Invert_Number_Click);
        }

        private void Add_Close_Bracket_Button(Button _Button, IButton_Changer Buttons_Controller)
        {
            _Button.Click += new RoutedEventHandler(Buttons_Controller.Button_Close_Bracket_Click);
        }

        private void Remove_EventHandlers(Button _Button, IButton_Changer Buttons_Controller)
        {
            _Button.Click -= Buttons_Controller.Button_Invert_Number_Click;
            _Button.Click -= Buttons_Controller.Button_Close_Bracket_Click;
        }
    }
}
