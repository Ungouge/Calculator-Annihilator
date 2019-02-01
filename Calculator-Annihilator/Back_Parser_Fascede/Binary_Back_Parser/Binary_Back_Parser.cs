using System;

namespace Calculator_Annihilator
{
    partial class Back_Parser_Fascede
    {
        /// <summary>
        /// Class to convert mantisa and exponent to return binary coeficient and exponent by IBack_Parser interface..
        /// </summary>
        internal partial class Binary_Back_Parser : IBack_Parser
        {
            private readonly int binary_Exponent;

            private long mantissa;

            short exponent;

            private string coeficient;

            /// <summary>
            /// Contruct class Binary Back Parser to return binary coeficient and exponent of given binary number by IBack_Parser interface.
            /// </summary>
            public Binary_Back_Parser( int _binary_Exponent, long _mantissa)
            {
                binary_Exponent = _binary_Exponent;

                mantissa = _mantissa;

                coeficient = Parse_Binary_Number_To_String(mantissa);

                exponent = (short)(binary_Exponent + coeficient.Length - 1);
            }
        }
    }
}
