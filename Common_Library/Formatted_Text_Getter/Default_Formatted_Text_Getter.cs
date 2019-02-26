using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Common_Library
{
    /// <summary>
    /// XYZ
    /// </summary>
    public partial class Formatted_Text_Getter
    {
        private FormattedText Formatted_Text;

        /// <summary>
        /// XYZ
        /// </summary>
        public Formatted_Text_Getter(TextBox _TextBox, double default_FontSize)
        {
            Formatted_Text = Get_Default_Formatted_Text(_TextBox.Text, _TextBox.FontFamily, _TextBox.FontStyle,
                _TextBox.FontWeight, _TextBox.FontStretch, default_FontSize);
        }

        /// <summary>
        /// XYZ
        /// </summary>
        public Formatted_Text_Getter(TextBlock _TextBlock, double default_FontSize)
        {
            Formatted_Text = Get_Default_Formatted_Text(_TextBlock.Text, _TextBlock.FontFamily, _TextBlock.FontStyle,
                _TextBlock.FontWeight, _TextBlock.FontStretch, default_FontSize);
        }

        /// <summary>
        /// Returns FormattedText class for passed text blox for passed font size
        /// </summary>
        private FormattedText Get_Default_Formatted_Text(string Text, FontFamily _FontFamily, FontStyle _FontStyle,
            FontWeight _FontWeight, FontStretch _FontStretch, double default_FontSize)
        {
            return new FormattedText(Text, CultureInfo.CurrentCulture, FlowDirection.LeftToRight,
                new Typeface(_FontFamily, _FontStyle, _FontWeight, _FontStretch), default_FontSize, Brushes.Black);
        }
    }
}
