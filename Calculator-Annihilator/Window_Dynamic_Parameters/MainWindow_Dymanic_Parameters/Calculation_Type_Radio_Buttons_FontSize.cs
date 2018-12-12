using System.Globalization;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;

namespace Calculator_Annihilator
{
    partial class MainWindow_Dynamic_Parameters
    {
        /// <summary>
        /// Gets font size for text of radio buttons in calculation type switcher
        /// </summary>
        public double Calculation_Type_Radio_Buttons_FontSize
        {
            get
            {
                Font_To_TextBlock_Matcher Matcher = new Font_To_TextBlock_Matcher(Current_Window);

                return Matcher.Match_Font_To_TextBlock();
            }
        }

        /// <summary>
        /// Class for calculations of text of radio buttons in calculation type switcher
        /// </summary>
        private class Font_To_TextBlock_Matcher
        {
            MainWindow Current_Window;

            /// <summary>
            /// Constructs new Font_To_TextBlock_Matcher
            /// </summary>
            public Font_To_TextBlock_Matcher(MainWindow _Current_Window)
            {
                Current_Window = _Current_Window;
            }

            /// <summary>
            /// Returns font size for text of radio buttons in calculation type switcher based on actual window size.
            /// </summary>
            public double Match_Font_To_TextBlock()
            {
                double default_FontSize = Current_Window.CalculationTypeSwitcher_Grid.ActualHeight / 3;

                FormattedText formatted_Text =
                    Get_Default_Formatted_Text(Current_Window.ComplexCalculations_RadioButton_TextBlock, default_FontSize);

                double actual_Size_Of_Text_Space =
                    (Current_Window.CalculationTypeSwitcher_Grid.ActualWidth * 7e-1) / formatted_Text.Width;

                if ( actual_Size_Of_Text_Space > 1)
                    return default_FontSize;
                else
                    return default_FontSize * actual_Size_Of_Text_Space;
            }

            /// <summary>
            /// Returns FormattedText class for passed text block for passed font size
            /// </summary>
            private static FormattedText Get_Default_Formatted_Text(TextBlock _TextBlock, double default_FontSize)
            {
                return new FormattedText(_TextBlock.Text, CultureInfo.CurrentCulture, FlowDirection.LeftToRight,
                    new Typeface(
                        _TextBlock.FontFamily, _TextBlock.FontStyle, _TextBlock.FontWeight, _TextBlock.FontStretch),
                    default_FontSize, Brushes.Black);
            }
        }
    }
}