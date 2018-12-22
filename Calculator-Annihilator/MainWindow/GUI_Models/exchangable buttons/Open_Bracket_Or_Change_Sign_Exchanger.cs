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

        protected internal void Set_Open_Bracket_Or_Change_Sign_Button(Button Button, Calculation_Method Calculation_Method, IButton_Changer Buttons_Controller)
        {
            if (Calculation_Method == Calculation_Method.Complex)
            {
                Button.Content = "(";

                Button.Click += new RoutedEventHandler(Buttons_Controller.Button_Open_Bracket_Click);
            }
            else
            {
                Button.Content = "+/-";

                Button.Click += new RoutedEventHandler(Buttons_Controller.Button_Change_Sign_Click);
            }
        }
    }
}
