using System;
using System.Windows;
using System.Windows.Controls;

namespace Calculator_Annihilator
{
    /// <summary>
    /// Class for setting features of passed button to function as open bracket or change sign button
    /// according to currently ussed calculation method.
    /// </summary>
    internal class Open_Bracket_Or_Change_Sign_Exchanger
    {
        /// <summary>
        /// Sets button features to function as open bracket or change sign button
        /// according to currently ussed calculation method.
        /// </summary>
        protected internal void Set_Open_Bracket_Or_Change_Sign_Button(
            Button _Button, Calculation_Method Calculation_Method, IButton_Changer Buttons_Controller)
        {
            Remove_EventHandlers(_Button, Buttons_Controller);

            if (Calculation_Method == Calculation_Method.Complex)
            {
                _Button.Content = "(";

                Add_Open_Bracket_Button(_Button, Buttons_Controller);
            }
            else
            {
                _Button.Content = "+/-";

                Add_Change_Sign_Button( _Button, Buttons_Controller);
            }
        }

        private void Add_Change_Sign_Button(Button _Button, IButton_Changer Buttons_Controller)
        {
             _Button.Click += new RoutedEventHandler(Buttons_Controller.Button_Change_Sign_Click);
        }

        private void Add_Open_Bracket_Button(Button _Button, IButton_Changer Buttons_Controller)
        {
            _Button.Click += new RoutedEventHandler(Buttons_Controller.Button_Open_Bracket_Click);
        }

        private void Remove_EventHandlers(Button _Button, IButton_Changer Buttons_Controller)
        {
            _Button.Click -= Buttons_Controller.Button_Change_Sign_Click;
            _Button.Click -= Buttons_Controller.Button_Open_Bracket_Click;
        }
    }
}
