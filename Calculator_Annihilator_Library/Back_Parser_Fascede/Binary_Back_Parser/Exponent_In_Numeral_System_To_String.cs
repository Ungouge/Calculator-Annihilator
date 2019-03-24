using System;

namespace Calculator_Annihilator_Library
{
    partial class Back_Parser_Fascede
    {
        partial class Binary_Back_Parser
        {
            /// <summary>
            /// Returns given exponent value to string of binary representation.
            /// </summary>
            public string Exponent_In_Numeral_System_To_String(short exponent)
            {
                bool is_Negative = false;

                if (exponent < 0)
                {
                    exponent *= -1;

                    is_Negative = true;
                }
                
                 return ((is_Negative == true) ? "-" : "") + Parse_Binary_Number_To_String(exponent);
            }
        }
    }
}
