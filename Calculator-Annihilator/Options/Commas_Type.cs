using System;
using System.Linq;

namespace Calculator_Annihilator
{
    partial class Options
    {
        private string comma_Type;

        internal string Comma_Type
        {
            get
            {
                return comma_Type;
            }

            set
            {
                comma_Type = value;
                    
                foreach (string comma in Commas_Type_Array)
                {
                    if (comma == value)
                        return;
                }

                Commas_Type_Array = Commas_Type_Array.Concat(new string[] { value }).ToArray();
            }

        }

        internal string[] Commas_Type_Array { get; private set; } = Signs_Lib.Commas_Type;
    }
}
