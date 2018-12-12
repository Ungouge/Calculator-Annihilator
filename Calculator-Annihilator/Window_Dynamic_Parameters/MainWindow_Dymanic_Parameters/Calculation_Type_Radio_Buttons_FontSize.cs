using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator_Annihilator
{
    partial class MainWindow_Dynamic_Parameters
    {
        public double Calculation_Type_Radio_Buttons_FontSize
        {
            get
            {
                Font_To_TextBox_Macher(Current_Window.SingleCalculations_TextBlock);
                TextBlock
                   ; TextBox
                double x = Current_Window.SingleCalculations.ActualHeight ;

                Current_Window.Reset_WorkSpace_Text(x.ToString());

                return x;
            }
        }
    }
}