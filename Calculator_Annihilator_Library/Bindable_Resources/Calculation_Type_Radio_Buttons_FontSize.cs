using System.Globalization;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using Common_Library;
using IMain_Window;

namespace Calculator_Annihilator_Library
{
    partial class Bindable_Resources
    {
        /// <summary>
        /// Gets font size for text of radio buttons in calculation type switcher
        /// </summary>
        public double Calculation_Type_Radio_Buttons_FontSize
        {
            get
            {
                Font_To_TextBlock_Matcher Matcher = new Font_To_TextBlock_Matcher(MainWindow);

                return Matcher.Match_Font_To_TextBlock();
            }
        }

        /// <summary>
        /// Class for calculations of text of radio buttons in calculation type switcher
        /// </summary>
        private class Font_To_TextBlock_Matcher
        {
            IMainWindow_Calculation_Method_Switcher MainWindow;

            const double RadioButton_Text_Part_Of_Total_Width = 65e-2;

            /// <summary>
            /// Constructs new Font_To_TextBlock_Matcher
            /// </summary>
            internal Font_To_TextBlock_Matcher(IMainWindow_Calculation_Method_Switcher _MainWindow)
            {
                MainWindow = _MainWindow;
            }

            /// <summary>
            /// Returns font size for text of radio buttons in calculation type switcher based on actual window size.
            /// </summary>
            internal double Match_Font_To_TextBlock()
            {
                double default_FontSize = MainWindow.Get_CalculationTypeSwitcher_Grid.ActualHeight / 3;

                Formatted_Text_Getter Formatted_Text =
                    new Formatted_Text_Getter(MainWindow.Get_ComplexCalculations_TextBlock, default_FontSize);
                FormattedText formatted_Text =
                    Get_Default_Formatted_Text(MainWindow.Get_ComplexCalculations_TextBlock, default_FontSize);

                double actual_Size_Of_Text_Space =
                    (MainWindow.Get_CalculationTypeSwitcher_Grid.ActualWidth * RadioButton_Text_Part_Of_Total_Width) /
                    Formatted_Text.Get_Text_Width;

                if (actual_Size_Of_Text_Space > 1)
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