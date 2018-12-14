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
            if (false /*settings file exist condition*/)
            {
                //Mocks reading of setting file
                calculator_Mode = Calculator_Mode.Standard;

                calculation_Method = Calculation_Method.Single;

                initial_Height = 510;
                initial_Width = 420;
                numeral_System = 10;
            }
            else // file does not exist
            {
                //create new setteng file

                //first run welcome pop up or information about lost setting file

                calculator_Mode = Calculator_Mode.Standard;

                calculation_Method = Calculation_Method.Single;

                initial_Height = 510;
                initial_Width = 420;
                numeral_System = 10;
            }
        }
    }

}
