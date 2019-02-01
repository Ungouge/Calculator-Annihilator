using System;

namespace Calculator_Annihilator
{
    partial class Back_Parser_Fascede
    {
        /// <summary>
        /// Returns given number as string in form of engineering notation.
        /// </summary>
        private string Return_Engineering_Notation(IBack_Parser Back_Parser, string comma_Type)
        {
            // Engineering notation expresses number as a product of coeficient and exponent presented
            // as power of base of mumeral system, as in scientific notation but forced to round down
            // the exponent to full multplication of 3. As a consequence the comma sign
            // maybe placed somewhere between four of first significant digits of the coeficient.
            // https://en.wikipedia.org/wiki/Engineering_notation

            string output = Back_Parser.Get_Coeficient;

            short current_Exponent = Back_Parser.Get_Exponent_Value;

            byte comma_shift = 0;

            while (current_Exponent % 3 != 0)
            {
                comma_shift++;
                current_Exponent--;
            }

            if (comma_shift == 0)
            {
                if (Back_Parser.Get_Coeficient.Length > 1)
                {
                    output = output.Insert(1, comma_Type);
                }
            }
            else if (Back_Parser.Get_Coeficient.Length > comma_shift )
            {
                output = output.Insert(comma_shift + 1 , comma_Type);
            }
            else if (comma_shift == Back_Parser.Get_Coeficient.Length)
            {
                output += '0';
            }
            else if (comma_shift == 2 && Back_Parser.Get_Coeficient.Length == 1)
            {
                output += "00";
            }

            output += Scientific_Exponent(Back_Parser.Exponent_In_Numeral_System_To_String(current_Exponent), Back_Parser.Numeral_System_Type);

            return output;
        }
    }
}
