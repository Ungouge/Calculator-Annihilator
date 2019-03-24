using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator_Annihilator
{
    partial class Options
    {
        public void Add_New_Comma_Type(string[] new_Comma_Type)
        {
            List<string> New_Comma_Type_List = new List<string>();

            foreach (string comma_Type in new_Comma_Type)
            {
                if (Is_New_Comma_Type(comma_Type))
                    New_Comma_Type_List.Add(comma_Type);
            }

            Commas_Type_Array = Commas_Type_Array.Concat(New_Comma_Type_List).ToArray();
        }

        private bool Is_New_Comma_Type(string comma_Type)
        {
            foreach (string comma in Commas_Type_Array)
                if (comma == comma_Type)
                    return false;

            return true;
        }
    }
}