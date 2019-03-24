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
            return Parse_Back
                (Number,
                Options.Numeral_System_Code,
                Options.Number_Notation,
                Options.Comma_Type
                );
        }

        /// <summary>
        /// Returns given number to string representation of a number according to passed settings
        /// </summary>
        protected string Parse_Back(INumber Number, sbyte _numeral_system_Type, Number_Notation Number_Notation, string comma_Type)
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

            return  Numeral_System_Selector(number, Number_Notation, _numeral_system_Type, comma_Type);
        }
    }
}