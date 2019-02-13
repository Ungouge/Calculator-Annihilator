using System;
using System.Windows;

namespace Calculator_Annihilator
{
    /// <summary>
    /// Class to read options file or generate new if there is non.
    /// </summary>
    public partial class Settings_File_Reader
    {
        Options_Storage options;

        internal Settings_File_Reader()
        {
            options = new Options_Storage
            (
                (Calculator_Mode)Properties.Settings.Default.Calculator_Mode,
                (Calculation_Method)Properties.Settings.Default.Calculation_Method,
                Properties.Settings.Default.initial_Height,
                Properties.Settings.Default.initial_Width,
                (Number_Notation)Properties.Settings.Default.Number_Notation,
                Properties.Settings.Default.comma_Type,
                (Font_Size_Type)Properties.Settings.Default.Font_Size_Type,
                Properties.Settings.Default.numeral_System,
                (Languages)Properties.Settings.Default.Language
            );

            //_Static_Resources.Comma_Type = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;

            //Default Values:
            //calculator_Mode = Calculator_Mode.Standard;
            //calculation_Method = Calculation_Method.Single;
            //number_Notation = Number_Notation.Normal; 
            //Language = Languages.English;
            //initial_Height = 510;
            //initial_Width = 420;
            //numeral_System = 10;
        }
    }

}
