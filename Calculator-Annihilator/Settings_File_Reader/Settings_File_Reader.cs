using System;
using System.Collections.Generic;
using Common_Library;
using Options_Library;

namespace Calculator_Annihilator
{
    /// <summary>
    /// Class to read options file or generate new if there is non.
    /// </summary>
    internal partial class Settings_File_Reader
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

            Pinned_Numeral_Systems.Set_Numeral_Systems_Codes = Read_Pinnend_Numeral_Systems;
            //_Static_Resources.Comma_Type = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;

            //Default Values:
            //calculator_Mode = Calculator_Mode.Standard;
            //calculation_Method = Calculation_Method.Single;
            //number_Notation = Number_Notation.Normal; 
            //Language = Languages.English;
            //initial_Height = 510;
            //initial_Width = 420;
            //Pinnend_Numeral_Systems = "2,8,10,12,16
            //numeral_System = 10;
        }

        private sbyte[] Read_Pinnend_Numeral_Systems
        {
            get
            {
                string Pined_Numeral_Systems = Properties.Settings.Default.Pined_Numeral_Systems;

                string[] Systems_Array = Pined_Numeral_Systems.Split(',');

                List<sbyte> Systems_Code_Array = new List<sbyte>();

                foreach (string system in Systems_Array)
                {
                    if (SByte.TryParse(system, out sbyte system_Code))
                    {
                        Systems_Code_Array.Add(system_Code);
                    }
                }

                return Systems_Code_Array.ToArray();
            }
        }
    }

}
