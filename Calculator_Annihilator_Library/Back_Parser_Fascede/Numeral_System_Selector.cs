using System;
using Common_Library;

namespace Calculator_Annihilator_Library
{
    partial class Back_Parser_Fascede
    {
        /// <summary>
        /// According to given numeral select proper method to return given number to string
        /// representation of a number.
        /// </summary>
        private string Numeral_System_Selector(double number, Number_Notation Number_Notation, sbyte numeral_System_Type, string comma_Type)
        {
            if (numeral_System_Type > 1)
            {
                return Positional_Numeral_System(number, Number_Notation, numeral_System_Type, comma_Type);
            }
            else
            {
                switch (numeral_System_Type)
                {
                    case 1:
                        return Unary_Numeral_System(number);
                    case -2:
                        return Negabinary_Numeral_System(number);
                    case -3:
                        return Balanced_Ternary_Numeral_System(number);
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}