using System;
using System.Windows;

namespace Calculator_Annihilator
{
    /// <summary>
    /// Class to read options file or generate new if there is non.
    /// </summary>
    internal partial class Settings_File_Reader
    {
        public Settings_File_Reader()
        {
            //Mocks reading of setting file
            calculator_Mode = (Calculator_Mode) Properties.Settings.Default.Calculator_Mode;

            calculation_Method = (Calculation_Method) Properties.Settings.Default.Calculation_Method;

            initial_Height = Properties.Settings.Default.initial_Height;
            initial_Width = Properties.Settings.Default.initial_Width;
            numeral_System = Properties.Settings.Default.numeral_System;



            //Default Values
            //calculator_Mode = Calculator_Mode.Standard;
            //calculation_Method = Calculation_Method.Single;
            //initial_Height = 510;
            //initial_Width = 420;
            //numeral_System = 10;
        }
    }

}
