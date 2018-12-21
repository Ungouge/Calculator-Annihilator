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
    internal class Close_Bracket_Or_Invert_Number_Exchanger : Buttons_Exchanger_Base
    {

        public Close_Bracket_Or_Invert_Number_Exchanger(Button _Button, Calculation_Method _Calculation_Method, IButton_Changer _Buttons_Controller)
            : base(_Button, _Calculation_Method, _Buttons_Controller)
        {
            // Empty
        }

        protected internal void Set_Close_Bracket_Or_Invert_Number_Button()
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
