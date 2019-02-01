using System;

namespace Calculator_Annihilator
{
    partial class Back_Parser_Fascede 
    {
        /// <summary>
        /// Class to convert number in binary form to form in given positional numeral system from 3 to 64
        /// and return coeficient and exponent by IBack_Parser interface.
        /// </summary>
        internal partial class Positional_Back_Parser : IBack_Parser
        {
            Arbitrary_Digits Arbitrary_Digits;

            sbyte numeral_System_Type;

            /// <summary>
            /// Contruct class Positional Back Parser to return in given numeral system coeficient
            /// and exponent of given binary number by IBack_Parser interface.
            /// </summary>
            public Positional_Back_Parser(sbyte _numeral_System_Type, int binary_Exponent, long mantissa)
            {
                numeral_System_Type = _numeral_System_Type;

                if (mantissa == 0)
                    Arbitrary_Digits = new Arbitrary_Digits(numeral_System_Type, 0, 0);
                else
                    Arbitrary_Digits =
                        new Arbitrary_Digits(numeral_System_Type, mantissa, binary_Exponent);
            }
        }
    }
}

