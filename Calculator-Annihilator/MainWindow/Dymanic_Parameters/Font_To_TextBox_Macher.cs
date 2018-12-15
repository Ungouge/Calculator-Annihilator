using System;
using System.Globalization;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        partial class Dynamic_Parameters
        {
            /// <summary>
            /// Class for font size calculations of text boxes of Main Window
            /// </summary>
            private class Font_To_TextBox_Matcher
            {
                TextBox _TextBox;
                int wrap_Factor = 1;

                /// <summary>
                /// Constucts new Font_To_TextBox_Matcher
                /// </summary>
                internal Font_To_TextBox_Matcher(TextBox __TextBox)
                {
                    _TextBox = __TextBox;
                }


                /// <summary>
                /// Returns font size for text boxes of Main Window.
                /// </summary>
                internal double Match_Font_To_TextBox()
                {
                    double default_FontSize = _TextBox.ActualHeight / 1.5;

                    _TextBox.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;

                    FormattedText formatted_Text = Get_Default_Formatted_Text(_TextBox, default_FontSize);

                    double actual_Size_Of_Text_Space = _TextBox.ActualWidth - 16;

                    if (formatted_Text.Width < actual_Size_Of_Text_Space)
                    {
                        _TextBox.TextWrapping = TextWrapping.NoWrap;
                        return Return_Non_Less_Than(default_FontSize);
                    }
                    else
                    {
                        double wraped_FontSize = Matching_Font_To_TextBox();

                        double rescaled_FontSize = default_FontSize * (actual_Size_Of_Text_Space / formatted_Text.Width);

                        if (wraped_FontSize > rescaled_FontSize)
                        {
                            _TextBox.TextWrapping = TextWrapping.Wrap;
                            _TextBox.MaxLines = wrap_Factor;
                            return Return_Non_Less_Than(wraped_FontSize);
                        }
                        else
                        {
                            _TextBox.TextWrapping = TextWrapping.NoWrap;
                            return Return_Non_Less_Than(rescaled_FontSize);
                        }
                    }
                }

                /// <summary>
                /// Returns font size for text boxes of Main Window when text needs more thanone line.
                /// </summary>
                private double Matching_Font_To_TextBox()
                {
                    double default_FontSize = _TextBox.ActualHeight / (15e-1 * wrap_Factor);

                    FormattedText formatted_Text = Get_Default_Formatted_Text(_TextBox, default_FontSize);

                    if (formatted_Text.Width < (_TextBox.ActualWidth - 16) * wrap_Factor)
                    {
                        return Return_Non_Less_Than(default_FontSize);
                    }
                    else
                    {
                        wrap_Factor++;
                        return Matching_Font_To_TextBox();
                    }
                }

                /// <summary>
                /// Don't allow to return font size lesser than 12.
                /// </summary>
                private double Return_Non_Less_Than(double FontSize)
                {
                    if (FontSize < 12)
                    {
                        _TextBox.TextWrapping = TextWrapping.Wrap;
                        _TextBox.VerticalScrollBarVisibility = ScrollBarVisibility.Visible;
                        return 12;
                    }

                    return FontSize;
                }

                /// <summary>
                /// Returns FormattedText class for passed text blox for passed font size
                /// </summary>
                private static FormattedText Get_Default_Formatted_Text(TextBox _TextBox, double default_FontSize)
                {
                    return new FormattedText(_TextBox.Text, CultureInfo.CurrentCulture, FlowDirection.LeftToRight,
                        new Typeface(_TextBox.FontFamily, _TextBox.FontStyle, _TextBox.FontWeight, _TextBox.FontStretch),
                        default_FontSize, Brushes.Black);
                }
            }
        }
    }
}
