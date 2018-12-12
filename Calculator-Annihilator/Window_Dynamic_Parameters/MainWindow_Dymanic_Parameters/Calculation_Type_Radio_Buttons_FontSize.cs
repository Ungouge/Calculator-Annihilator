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
                Font_To_TextBlock_Matcher Matcher = new Font_To_TextBlock_Matcher(Current_Window);

                return Matcher.Match_Font_To_TextBlock();
            }
        }

        private class Font_To_TextBlock_Matcher
        {
            MainWindow Current_Window;

            public Font_To_TextBlock_Matcher(MainWindow _Current_Window)
            {
                Current_Window = _Current_Window;
            }

            public double Match_Font_To_TextBlock()
            {
                double default_FontSize = Current_Window.CalculationTypeSwitcher_Grid.ActualHeight / 3;

                FormattedText formatted_Text = Get_Default_Formatted_Text(Current_Window.ComplexCalculations_RadioButton_TextBlock, default_FontSize);

                double actual_Size_Of_Text_Space = (Current_Window.CalculationTypeSwitcher_Grid.ActualWidth - 32) / formatted_Text.Width;

                if ( actual_Size_Of_Text_Space > 1)
                    return default_FontSize;
                else
                    return default_FontSize * actual_Size_Of_Text_Space;
            }

            private static FormattedText Get_Default_Formatted_Text(TextBlock _TextBlock, double default_FontSize)
            {
                return new FormattedText(_TextBlock.Text, CultureInfo.CurrentCulture, FlowDirection.LeftToRight,
                    new Typeface(_TextBlock.FontFamily, _TextBlock.FontStyle, _TextBlock.FontWeight, _TextBlock.FontStretch),
                    default_FontSize, Brushes.Black);
            }
        }
    }
}