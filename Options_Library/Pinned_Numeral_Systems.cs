using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Options_Library
{
    public static class Pinned_Numeral_Systems
    {
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

        public static void Add_Numeral_System(sbyte new_Numeral_System_Code)
        {
            Numeral_Systems_Codes_List.Add(new_Numeral_System_Code);

            Numeral_Systems_Codes_List.Sort();
        }

        public static void Remove_Numeral_System(sbyte new_Numeral_System_Code)
        {
            if (Is_Numeral_sytem_Pinned(new_Numeral_System_Code) == true)
                Numeral_Systems_Codes_List.Remove(new_Numeral_System_Code);

            Numeral_Systems_Codes_List.Sort();
        }

        public static bool Is_Numeral_sytem_Pinned(sbyte numeral_System_Code)
        {
            foreach (sbyte pinned_Numeral_System in Get_Numeral_Systems_Codes)
                if (pinned_Numeral_System == numeral_System_Code)
                    return true;

            return false;
        }
    }


}