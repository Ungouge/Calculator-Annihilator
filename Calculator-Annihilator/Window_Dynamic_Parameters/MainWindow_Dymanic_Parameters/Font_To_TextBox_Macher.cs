﻿using System;
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
        private class Font_To_TextBox_Matcher
        {
            TextBox _TextBox;

            public Font_To_TextBox_Matcher(TextBox __TextBox)
            {
                _TextBox = __TextBox;
            }

            public double Match_Font_To_TextBox()
            {
                double default_FontSize = _TextBox.ActualHeight / 1.5;

                FormattedText formatted_Text = Get_Default_Formatted_Text(_TextBox, default_FontSize);

                double actual_Size_Of_Text_Space = _TextBox.ActualWidth - 16;

                if (formatted_Text.Width < actual_Size_Of_Text_Space)
                {
                    _TextBox.TextWrapping = TextWrapping.NoWrap;
                    return default_FontSize;
                }
                else
                {
                    double wraped_FontSize = Matching_Font_To_TextBox1( 1);

                    double rescaled_FontSize = default_FontSize * (actual_Size_Of_Text_Space / formatted_Text.Width);

                    if ( wraped_FontSize > rescaled_FontSize)
                    {
                        _TextBox.TextWrapping = TextWrapping.Wrap;
                        return wraped_FontSize;
                    }
                    else
                    {
                        _TextBox.TextWrapping = TextWrapping.NoWrap;
                        return rescaled_FontSize;
                    }
                }
            }

            private double Matching_Font_To_TextBox1( int wrap_Factor)
            {
                double default_FontSize = _TextBox.ActualHeight / (1.5 * wrap_Factor);

                FormattedText formatted_Text = Get_Default_Formatted_Text(_TextBox, default_FontSize);

                if (formatted_Text.Width < (_TextBox.ActualWidth - 16) * wrap_Factor)
                {
                    _TextBox.MaxLines = wrap_Factor;
                    return default_FontSize;
                }
                else
                    return Matching_Font_To_TextBox1( ++wrap_Factor);
            }

            private static FormattedText Get_Default_Formatted_Text(TextBox _TextBox, double default_FontSize)
            {
                return new FormattedText(_TextBox.Text, CultureInfo.CurrentCulture, FlowDirection.LeftToRight,
                    new Typeface(_TextBox.FontFamily, _TextBox.FontStyle, _TextBox.FontWeight, _TextBox.FontStretch),
                    default_FontSize, Brushes.Black);
            }
        }
    }
}
