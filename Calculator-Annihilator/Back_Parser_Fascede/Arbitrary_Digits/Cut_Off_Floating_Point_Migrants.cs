using System;

namespace Calculator_Annihilator
{
    partial class Back_Parser_Fascede
    {
        partial class Arbitrary_Digits
        {
            /// <summary>
            /// Cutts off redundant digits beyond precition of floating point and smoths possible shifts
            /// of number coused by floating point migration consequently to numeral system.
            /// </summary>
            private void Cut_Off_Floating_Point_Migrants()
            {
                int cut_At = Digit_List.Count - precition + 3;

                if (cut_At >= 0)
                {
                    cut_At = Smooth_To(cut_At);

                    Digit_List = Digit_List.GetRange(cut_At, Digit_List.Count - cut_At);
                }

                Digit_List = Normalize();
            }
        }
    }
}