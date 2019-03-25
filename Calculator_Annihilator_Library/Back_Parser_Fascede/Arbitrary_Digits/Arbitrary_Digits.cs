using System;

namespace Calculator_Annihilator_Library
{
    partial class Back_Parser_Fascede
    {
        /// <summary>
        /// Class to create string with number coeficient by creating list of arbitrary digits, then moves them by binary exponent
        /// to adjust coeficent and exponent to given positional numeral system.
        /// </summary>
        private partial class Arbitrary_Digits
        {
            /// <summary>
            /// Constructs new Arbitrary Digits class.
            /// </summary>
            public Arbitrary_Digits(sbyte _Numeral_System, long _mantissa, int _binary_Exponent)
            {
                mantissa = _mantissa;

                binary_Exponent = _binary_Exponent;

                numeral_System = _Numeral_System;

                precition = Numeral_System_Precition;

                _Divide_By_Two_Method_Delegate = Set_Divide_By_Two_Method();

                half_Of_Numeral_System = (byte)(numeral_System / 2);

                Calculate_Arbitrary_Digits();
            }
        }
    }
}
//num_sys | precition
//  2	  |    53
//  3	  |    34
//  4	  |    27
//  5	  |    24
//  6	  |    22
//  7	  |    20
//  8	  |    19
//  9	  |    18
//  10	  |    17
//  11	  |    17
//  12	  |    16
//  13	  |    16
//  14	  |    15
//  15	  |    15
//  16	  |    14
//  17	  |    14
//  18	  |    14
//  19	  |    14
//  20	  |    14
//  21	  |    13
//  22	  |    13
//  23	  |    13
//  24	  |    13
//  25	  |    13
//  26	  |    13
//  27	  |    12
//  28	  |    12
//  29	  |    12
//  30	  |    12
//  31	  |    12
//  32	  |    12
//  33	  |    12
//  34	  |    12
//  35	  |    12
//  36	  |    12
//  37	  |    11
//  38	  |    11
//  39	  |    11
//  40	  |    11
//  41	  |    11
//  42	  |    11
//  43	  |    11
//  44	  |    11
//  45	  |    11
//  46	  |    11
//  47	  |    11
//  48	  |    11
//  49	  |    11
//  50	  |    11
//  51	  |    11
//  52	  |    11
//  53	  |    11
//  54	  |    11
//  55	  |    10
//  56	  |    10
//  57	  |    10
//  58	  |    10
//  59	  |    10
//  60	  |    10
//  61	  |    10
//  62	  |    10
//  63	  |    10
//  64	  |    10