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
                Font_To_TextBlock_Matcher Matcher = new Font_To_TextBlock_Matcher(Current_Window.SingleCalculations_TextBlock);

                double x = Matcher.Match_Font_To_TextBlock();

                Current_Window.Reset_WorkSpace_Text(x.ToString());

                return x;
            }
        }

        private class Font_To_TextBlock_Matcher
        {
            TextBlock _TextBlock;

            public Font_To_TextBlock_Matcher(TextBlock __TextBlock)
            {
                _TextBlock = __TextBlock;
            }

            public double Match_Font_To_TextBlock()
            {
                double default_FontSize = _TextBlock.ActualHeight / 1.5; // do roper factor

                FormattedText formatted_Text = Get_Default_Formatted_Text(_TextBlock, default_FontSize);

                double actual_Size_Of_Text_Space = _TextBlock.ActualWidth - 16; //checked margins

                if (formatted_Text.Width < actual_Size_Of_Text_Space)
                    return default_FontSize;
                else
                    return default_FontSize * (actual_Size_Of_Text_Space / formatted_Text.Width);
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