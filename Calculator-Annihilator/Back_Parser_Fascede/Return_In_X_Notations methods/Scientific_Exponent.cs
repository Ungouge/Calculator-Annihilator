using System;

namespace Calculator_Annihilator
{
    partial class Back_Parser_Fascede
    {
        /// <summary>
        /// Returns scientific exponent of given value as string compose of base of numeral system 
        /// (it is always digits "10") and exponent as power. If it is possible the exponent is
        /// written as supersripted characters of digit, if not exponent is written
        /// as normal text after power sign "^".
        /// </summary>
        private string Scientific_Exponent(string exponent, sbyte numeral_System_Type)
        {
            string output;

            if (numeral_System_Type <= 10 && numeral_System_Type > 1)
            {
                output = "*10" + Decimal_Superscripted_Exponent(exponent);
            }
            else
            {
                output = "*(10^" + exponent + ')';
            }

            return output;
        }

        /// <summary>
        /// Returns given string of decimal digit charactes as superscripted text.
        /// </summary>
        private string Decimal_Superscripted_Exponent(string exponent)
        {
            string output = String.Empty;

            int i = 0;

            if (exponent[i] == '-')
            {
                output += '\x207B';

                i++;
            }

            for ( ; i < exponent.Length; i++)
                output += Superscripted_Digit__Map((byte)(exponent[i] - '0'));

            return output;
        }

        /// <summary>
        /// Returns given digit as superscripted character.
        /// </summary>
        private char Superscripted_Digit__Map(byte digit)
        {
            switch (digit)
            {
                case 1:
                    return '\xB9';
                case 2:
                    return '\xB2';
                case 3:
                    return '\xB3';
                default:
                    return (char)(digit + '\x2070');
            }
        }
    }
}
