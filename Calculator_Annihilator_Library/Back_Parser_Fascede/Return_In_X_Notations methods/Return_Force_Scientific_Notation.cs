using System;

namespace Calculator_Annihilator_Library
{
    partial class Back_Parser_Fascede
    {
        /// <summary>
        /// Returns given number as string always in form of scientific notation.
        /// </summary>
        private string Return_Force_Scientific_Notation(IBack_Parser Back_Parser, string comma_Type)
        {
            // Scientific notation expresses number as a product of coeficient and exponent presented
            // as power of base of mumeral system. Coeficient if is longer than one digit it contains
            // a comma sign right after the first digit.
            // https://en.wikipedia.org/wiki/Scientific_notation

            string output = Back_Parser.Get_Coeficient;

            if (output.Length > 1)
                output = output.Insert(1, comma_Type);

            output += Scientific_Exponent(
                Back_Parser.Exponent_In_Numeral_System_To_String(Back_Parser.Get_Exponent_Value),
                Back_Parser.Numeral_System_Type);

            return output;
        }
    }
}