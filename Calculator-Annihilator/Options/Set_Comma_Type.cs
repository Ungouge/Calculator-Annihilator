using System;
using System.Linq;

namespace Calculator_Annihilator
{
    partial class Options
    {
        public void Set_Comma_Type(string new_Comma_Type)
        {
            Comma_Type = new_Comma_Type;

            foreach (string comma in Commas_Type_Array)
            {
                if (comma == Comma_Type)
                    return;
            }

            Commas_Type_Array = Commas_Type_Array.Concat(new string[] { Comma_Type }).ToArray();
        }
    }
}
