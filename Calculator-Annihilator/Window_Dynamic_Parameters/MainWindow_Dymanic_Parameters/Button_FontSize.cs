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
        static double Height_Or_Width_Switch_Ration = 12e-1;

        public double Button_FontSize
        {
            get
            {
                double _Actual_Button_Height = Current_Window.ButtonGrid.ActualHeight / Current_Window.ButtonGrid.RowDefinitions.Count;
                double _Actual_Button_Weidth = Current_Window.ButtonGrid.ActualWidth / Current_Window.ButtonGrid.ColumnDefinitions.Count;

                if (_Actual_Button_Weidth / _Actual_Button_Height > Height_Or_Width_Switch_Ration)
                    return _Actual_Button_Height / 2  ;
                else
                    return (_Actual_Button_Weidth / (2 * Height_Or_Width_Switch_Ration));
            }
        }

    }
}