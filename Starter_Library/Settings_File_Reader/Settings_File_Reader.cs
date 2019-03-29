using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using Common_Library;
using Options_Library;

namespace Starter_Library
{
    /// <summary>
    /// Class to read options file or generate new if there is non.
    /// </summary>
    public partial class Settings_File_Reader : ISettings_File_Reader
    {
        Options_Storage Options;

        ISettings_Adapter Settings;

        public Settings_File_Reader(ISettings_Adapter _Settings)
        {
            Settings = _Settings;

            Options = new Options_Storage
            (
                (Calculator_Mode)(sbyte)Settings["Calculator_Mode"],
                (Calculation_Method)(sbyte)Settings["Calculation_Method"],
                (double)Settings["initial_Height"],
                (double)Settings["initial_Width"],
                (Number_Notation)(sbyte)Settings["Number_Notation"],
                (string)Settings["comma_Type"],
                (Font_Size_Type)(sbyte)Settings["Font_Size_Type"],
                (sbyte)Settings["numeral_System"],
                (Languages)(byte)Settings["Language"]
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
;