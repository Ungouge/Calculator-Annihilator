using System;
using System.Collections.Generic;

namespace Calculator_Annihilator
{
    partial class Back_Parser_Fascede
    {
        partial class Positional_Back_Parser
        {
            /// <summary>
            /// Returns given exponent value to string in current numeral system representation.
            /// </summary>
            public string Exponent_In_Numeral_System_To_String(short exponent)
            {
                string output = String.Empty;

                List<byte> Exponent_Digit_List = new List<byte>();

                if (exponent < 0)
                {
                    output += '-';

                    exponent *= -1;
                }

                do
                {
                    Exponent_Digit_List.Add((byte)(exponent % numeral_System_Type));

                    exponent /= numeral_System_Type;
                } while (exponent > 0);

                output += Digit_List_In_Numeral_System_To_String(Exponent_Digit_List);

                return output;
            }
        }
    }
}
