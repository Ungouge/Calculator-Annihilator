using System;

namespace Calculator_Annihilator
{
    partial class Back_Parser_Fascede
    {
        /// <summary>
        /// Returns given number as string in form of engineering or forced comma notation
        /// according to order of magnitue.
        /// </summary>
        private string Return_Normal_Notation(IBack_Parser Back_Parser, string comma_Type)
        {
            // Normal notation expresses number in engineering or forced comma notation according
            // to order of magnitue. For numbers that would need more than 30 digits (or long
            // as precition if precition of numeral systems is longer than 30) they would be
            // returned in exponent notation. If shorter than as it was described the number will be
            // returned in force radix base notation.
            short coeficient_Length = (short)Back_Parser.Get_Coeficient.Length;

            byte precition = Back_Parser.Numeral_System_Precition;

            if (precition < 30)
                precition = 30;

            if ((Back_Parser.Get_Exponent_Value > 0 && Back_Parser.Get_Exponent_Value < precition) ||
                (Back_Parser.Get_Exponent_Value <= 0 && coeficient_Length - Back_Parser.Get_Exponent_Value < precition))
            {
                return Return_Force_Radix_Base_Notation(Back_Parser, comma_Type);
            }
            else
            {
                return Return_Force_Exponent_Notation(Back_Parser, comma_Type);
            }
        }
    }
}