using System;

namespace Calculator_Annihilator_Library
{
    partial class Back_Parser_Fascede
    {
        /// <summary>
        /// Returns given number as string of number always in Exponent formn.
        /// </summary>
        private string Return_Force_Exponent_Notation(IBack_Parser Back_Parser, string comma_Type)
        {
            // Exponent notation expresses number as a product of coeficient and exponent
            // after the "E" character meaning exponent with subscripted decimal number
            // been base of current numeral system. Coeficient if is longer than one digit
            // it contains a comma sign right after the first digit.
            // https://en.wikipedia.org/wiki/Scientific_notation#E-notation

            string output = Back_Parser.Get_Coeficient;

            if (output.Length > 1)
                output = output.Insert(1, comma_Type);

            output += Exponent_Sign(Back_Parser.Numeral_System_Type);

            output += Back_Parser.Exponent_In_Numeral_System_To_String(Back_Parser.Get_Exponent_Value);
            
            if (Back_Parser.Numeral_System_Type > 14)
                output += ")";

            return output;
        }

        /// <summary>
        /// Return appropriate exponent sign for given numeral system. That is "E" with subscripted
        /// decimal representation of numeral sytem except of decimal system. For systems highier
        /// than 14 the exponent sign is in bracket to differ E from the exponet from digit E = 14.
        /// </summary>
        private string Exponent_Sign(sbyte numeral_System_Type)
        {
            string output = String.Empty;

            if (numeral_System_Type < 14 && numeral_System_Type > 1)
            {
                output += "E";

                if (numeral_System_Type != 10)
                {
                    if (numeral_System_Type > 10)
                        output += ("\x2081");

                    output += (char)((numeral_System_Type % 10) + '\x2080');
                }
            }
            else if (numeral_System_Type > 14)
            {
                output += "(E";
                output += (char)((numeral_System_Type / 10) + '\x2080');
                output += (char)((numeral_System_Type % 10) + '\x2080');
            }
            else
            {
                switch (numeral_System_Type)
                {
                    case -2:
                        output = "E\x208B\x2082";
                        break;
                    default:
                        output = "E\x2099\x209B";
                        break;
                }
            }

            return output;
        }
    }
}
