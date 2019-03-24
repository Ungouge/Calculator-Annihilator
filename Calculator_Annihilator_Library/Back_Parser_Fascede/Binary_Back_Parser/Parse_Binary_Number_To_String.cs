using System;
using System.Text;

namespace Calculator_Annihilator_Library
{
    partial class Back_Parser_Fascede
    {
        partial class Binary_Back_Parser
        {
            /// <summary>
            /// Returns given number to string form of binary number.
            /// </summary>
            private string Parse_Binary_Number_To_String(long number)
            {
                StringBuilder output = new StringBuilder();

                do
                {
                    if (number % 2 == 1)
                        output.Insert(0,'1');
                    else
                        output.Insert(0, '0');

                    number >>= 1;
                } while (number != 0);

                return output.ToString();
            }
        }
    }
}
