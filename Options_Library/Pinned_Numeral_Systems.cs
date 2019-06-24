using System;
using System.Collections.Generic;
using System.Linq;

namespace Options_Library
{
    /// <summary>
    /// Stores list of pinned numeral systems and manages it.
    /// </summary>
    public static class Pinned_Numeral_Systems
    {
        private readonly static List<sbyte> Defualt_Pinned_Numeral_Systems = new List<sbyte>() { 2, 8, 10, 12, 16, 60 };

        private static List<sbyte> Numeral_Systems_Codes_List = new List<sbyte>();

        public static sbyte[] Get_Numeral_Systems_Codes
        {
            get
            {
                return Numeral_Systems_Codes_List.ToArray();
            }
        }

        public static sbyte[] Set_Numeral_Systems_Codes
        {
            set
            {
                Numeral_Systems_Codes_List = value.ToList();

                Numeral_Systems_Codes_List.Sort();
            }
        }

        /// <summary>
        /// Add given numeral system to the list.
        /// </summary>
        public static void Add_Numeral_System(sbyte new_Numeral_System_Code)
        {
            Numeral_Systems_Codes_List.Add(new_Numeral_System_Code);

            Numeral_Systems_Codes_List.Sort();
        }


        /// <summary>
        /// Removes given numeral system from the list, if numeral system is on it.
        /// </summary>
        public static void Remove_Numeral_System(sbyte new_Numeral_System_Code)
        {
            if (Is_Numeral_System_Pinned(new_Numeral_System_Code) == true)
                Numeral_Systems_Codes_List.Remove(new_Numeral_System_Code);
        }

        /// <summary>
        /// Cheks is given numeral system is currently pinned.
        /// </summary>
        public static bool Is_Numeral_System_Pinned(sbyte numeral_System_Code)
        {
            foreach (sbyte pinned_Numeral_System in Get_Numeral_Systems_Codes)
                if (pinned_Numeral_System == numeral_System_Code)
                    return true;

            return false;
        }
    }
}