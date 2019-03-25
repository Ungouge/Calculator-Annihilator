using System;

namespace Calculator_Annihilator_Library
{
    partial class Back_Parser_Fascede
    {
        partial class Double_Precition_Decomposer
        {
            /// <summary>
            /// Decompose double precition floating point number to mantissa, exponent
            /// and check it is a negative number.
            /// </summary>
            /// <para>Based on http://jonskeet.uk/csharp/DoubleConverter.cs </para>
            protected internal void Decompose(double number)
            {
                long number_Bits = BitConverter.DoubleToInt64Bits(number);

                // Reading sign

                Is_Negative = (number_Bits < 0);

                // Reading exponent

                Binary_Exponent = (int)(number_Bits >> 52) & 0x7ff;

                // reading mantissa 

                Mantissa = number_Bits & 0xfffffffffffffL;

                // normalize subnormal number.

                if (Binary_Exponent == 0)
                    Binary_Exponent++;
                else
                    Mantissa = Mantissa | (1L << 52);

                // Biasing the exponent.

                Binary_Exponent -= 1075;

                if (Mantissa == 0)
                    return;

                // Normalize

                while ((Mantissa & 1L) == 0)
                {
                    Mantissa >>= 1;
                    Binary_Exponent++;
                }
            }
        }
    }
}
