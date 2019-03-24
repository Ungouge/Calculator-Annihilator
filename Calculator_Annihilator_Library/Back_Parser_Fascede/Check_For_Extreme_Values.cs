using System;

namespace Calculator_Annihilator_Library
{
    partial class Back_Parser_Fascede
    {
        /// <summary>
        /// Check does passed number is not finite/incalculable number such as infinty or NaN.
        /// If so returns Exception with 
        /// </summary>
        /// <exception cref="NotFiniteNumberException"/>
        private void Check_For_Extreme_Values(double number)
        {
            ///xyz add language options
            if (double.IsNaN(number) == true)
                throw new NotFiniteNumberException("NaN");

            if (double.IsNegativeInfinity(number) == true)
                throw new NotFiniteNumberException("-infinity");

            if (double.IsPositiveInfinity(number) == true)
                throw new NotFiniteNumberException("+infinity");
        }
    }
}
