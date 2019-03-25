using System;
using Common_Library;
using Options_Library;

namespace Calculator_Annihilator_Library
{
    partial class Back_Parser_Fascede
    {
        /// <summary>
        /// Returns given number to string representation of a number according to current
        /// settings of the calculator.
        /// </summary>
        public string Parse_Back(INumber Number)
        {
            double number = Number.Value;

            try
            {
                Check_For_Extreme_Values(number);
            }
            catch (NotFiniteNumberException e)
            {
                return e.Message; // xyz returnig proper message from library to implement, try catch also all zeroes
            }

            return  Numeral_System_Selector(number, Number_Notation, numeral_system_Type, comma_Type);
        }
    }
}