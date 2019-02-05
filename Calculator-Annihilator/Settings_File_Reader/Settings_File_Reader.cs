using System;
using System.Windows;

namespace Calculator_Annihilator
{
    /// <summary>
    /// Class to read options file or generate new if there is non.
    /// </summary>
    public partial class Settings_File_Reader
    {
        public Settings_File_Reader()
        {
            calculator_Mode = (Calculator_Mode) Properties.Settings.Default.Calculator_Mode;

            calculation_Method = (Calculation_Method) Properties.Settings.Default.Calculation_Method;

            number_Notation = (Number_Notation)Properties.Settings.Default.Number_Notation;

            Language = (Languages)Properties.Settings.Default.Language;

            initial_Height = Properties.Settings.Default.initial_Height;
            initial_Width = Properties.Settings.Default.initial_Width;
            numeral_System = Properties.Settings.Default.numeral_System;

            comma_Type = Properties.Settings.Default.comma_Type;

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
