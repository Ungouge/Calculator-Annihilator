using System;
using Common_Library;

namespace Calculator_Annihilator
{
    partial class Back_Parser_Fascede
    {
        /// <summary>
        /// Returns given number in given positonal numeral system.
        /// </summary>
        private string Positional_Numeral_System(double number, Number_Notation Number_Notation, sbyte numeral_System_Type, string comma_Type)
        {
            Double_Precition_Decomposer Decomposer = new Double_Precition_Decomposer(number);

            IBack_Parser Back_Parser = Construnct_Positional_Back_Parser(numeral_System_Type, Decomposer);

            return (Decomposer.Is_Negative ? "-" : String.Empty) +
                Return_Notation_Selector(Back_Parser, Number_Notation, comma_Type);
        }

        /// <summary>
        /// Returns IBack_Parser class according to numeral system.
        /// </summary>
        private static IBack_Parser Construnct_Positional_Back_Parser(sbyte _numeral_system_Type, Double_Precition_Decomposer Decomposer)
        {
            if (_numeral_system_Type > 2)
            {
                return new Positional_Back_Parser( _numeral_system_Type,
                    Decomposer.Binary_Exponent, Decomposer.Mantissa);
            }
            else if (_numeral_system_Type == 2)
            {
                return new Binary_Back_Parser(Decomposer.Binary_Exponent, Decomposer.Mantissa);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
