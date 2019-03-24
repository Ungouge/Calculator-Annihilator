using System;
using System.Collections.Generic;

namespace Calculator_Annihilator
{
    partial class Back_Parser_Fascede
    {
        partial class Arbitrary_Digits
        {
            /// <summary>
            /// Returns position of last significant digit in arbitrary coeficient smothing possible shifts
            /// of number coused by floating point migration consequently to numeral system.
            /// </summary>
            private int Smooth_To(int cut_At)
            {
                if (Digit_List[cut_At] <= 1)
                {
                    cut_At++;

                    while (cut_At < Digit_List.Count)
                    {
                        if (Digit_List[cut_At] < 1)
                        {
                            cut_At++;
                        }
                        else
                            break;
                    }
                }
                else
                {
                    if (cut_At > 0 && (Digit_List[cut_At - 1] > (numeral_System + 1) / 2))
                        Digit_List[cut_At]++;

                    while (cut_At < Digit_List.Count)
                    {
                        if (Digit_List[cut_At] >= numeral_System - 1)
                        {
                            cut_At++;
                        }
                        else
                            break;
                    }

                    if (cut_At >= Digit_List.Count)
                    {
                        Digit_List = new List<byte>() { 1 };

                        Comma_Position++;

                        cut_At = 0;
                    }
                    else
                    {
                        Digit_List[cut_At]++;
                    }
                }

                return cut_At;
            }
        }
    }
}
