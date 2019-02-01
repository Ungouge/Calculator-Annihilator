using System;

namespace Calculator_Annihilator
{
    partial class Back_Parser_Fascede
    {
        /// <summary>
        /// Returns given number as string in form of scientifc or forced comma notation
        /// for short numbers.
        /// </summary>
        private string Return_Scienfic_Normalized_Notation(IBack_Parser Back_Parser, string comma_Type)
        {
            // Scienfic normalized notation expresses number in scienfic or forced radix base notation
            // according to order of magnitue and length of the number. For numbers that
            // in forced radix base notation would need to add zeroes to the number it would be
            // returned in scienfic notation. In other case the number will be returned
            // in force radix base notation.

            int precition = Back_Parser.Numeral_System_Precition;

            short exponent_Value = Back_Parser.Get_Exponent_Value;

            if ((exponent_Value > 0 && exponent_Value < precition) && exponent_Value <= 0 &&
                0 - Back_Parser.Get_Coeficient.Length - exponent_Value > precition)
            {
                return Return_Force_Radix_Base_Notation(Back_Parser, comma_Type);
            }
            else
            {
                return Return_Force_Scientific_Notation(Back_Parser, comma_Type);
            }
        }
    }
}
