using System;

namespace Calculator_Annihilator
{
    partial class Back_Parser_Fascede
    {
        partial class Arbitrary_Digits
        {
            /// <summary>
            /// Calculates number coeficient as digits list, then moves them by binary exponent
            /// to adjust coeficent and exponent to given positional numeral system.  
            /// </summary>
            private void Calculate_Arbitrary_Digits()
            {
                // Convert binary mantissa to number in numeral system.

                Mantisa_To_Coefficients_Digit_List();

                // Shift decimal point of mantissa by binary exponent.

                if (binary_Exponent != 0)
                    Shift_Comma_Point();

                // Cut of additional digit and floating point.

                Cut_Off_Floating_Point_Migrants();
            }
        }
    }
}
