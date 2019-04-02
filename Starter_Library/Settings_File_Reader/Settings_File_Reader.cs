using System;
using System.Collections.Generic;
using Common_Library;
using Options_Library;

namespace Starter_Library
{
    /// <summary>
    /// Class to read options file or generate new if there is non.
    /// </summary>
    public partial class Settings_File_Reader : ISettings_File_Reader
    {
        public Settings_File_Reader(ISettings_Adapter _Settings)
        {
            Settings = _Settings;

            Calculator_Mode = (Calculator_Mode)Settings["Calculator_Mode"];

            Calculation_Method = (Calculation_Method)Settings["Calculation_Method"];

            initial_Height = (double)Settings["initial_Height"];

            initial_Width = (double)Settings["initial_Width"];

            Number_Notation = (Number_Notation)Settings["Number_Notation"];

            comma_Type = (string)Settings["comma_Type"];

            Font_Size_Type = (Font_Size_Type)Settings["Font_Size_Type"];

            numeral_System = (sbyte)Settings["numeral_System"];

            Language = (Languages)Settings["Language"];

            Options = new Options_Storage
            (
                Calculator_Mode,
                Calculation_Method,
                initial_Height,
                initial_Width,
                Number_Notation,
                comma_Type,
                Font_Size_Type,
                numeral_System,
                Language
            );

            Pinned_Numeral_Systems.Set_Numeral_Systems_Codes = Read_Pinnend_Numeral_Systems;
        }

        private sbyte[] Read_Pinnend_Numeral_Systems
        {
            get
            {
                string Pined_Numeral_Systems = (string)Settings["Pined_Numeral_Systems"];

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