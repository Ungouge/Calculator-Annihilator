using System;

namespace Calculator_Annihilator_Library
{
    partial class Back_Parser_Fascede
    {
        /// <summary>
        /// Class to decompose double precition floating point number to mantissa, exponent
        /// and check it is a negative number.
        /// </summary>
        protected partial class Double_Precition_Decomposer
        {
            internal bool Is_Negative { get; private set; }

            internal int Binary_Exponent { get; private set; }

            internal long Mantissa { get; private set; }

            /// <summary>
            /// Constructs Double Precition Decomposer class.
            /// </summary>
            /// <param name="number"></param>
            public Double_Precition_Decomposer(double number )
            {
                Decompose(number);
            }
        }
    }
}
