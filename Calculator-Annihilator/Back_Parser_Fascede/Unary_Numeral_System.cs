using System;

namespace Calculator_Annihilator
{
    partial class Back_Parser_Fascede
    {
        /// <summary>
        /// Returns given number in unary numeral system.
        /// </summary>
        private static string Unary_Numeral_System(double number)
        {
            Unary_Back_Parser Back_Parser = new Unary_Back_Parser(number);

            return Back_Parser.Number_To_String;
        }
    }
}
