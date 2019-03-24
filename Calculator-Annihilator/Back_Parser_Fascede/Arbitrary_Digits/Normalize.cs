using System;
using System.Collections.Generic;

namespace Calculator_Annihilator
{
    partial class Back_Parser_Fascede
    {
        partial class Arbitrary_Digits
        {
            /// <summary>
            /// Returns arbitrary digits list in normalized form  Cutting off redundant zeroes and
            /// cutts digits beyond precition of floating point migration consequently to numeral system.
            /// </summary>
            private List<byte> Normalize()
            {
                return Normalize(Digit_List);
            }

            /// <summary>
            /// Returns giveb arbitrary digits list in normalized form. Cutting off redundant zeroes
            /// and cutts digits beyond precition of floating point migration consequently to numeral system.
            /// </summary>
            private List<byte> Normalize(List<byte> Normalizing_List)
            {
                int first;

                for (first = 0; first < Normalizing_List.Count; first++)
                    if (Normalizing_List[first] != 0)
                        break;

                int last;

                for (last = Normalizing_List.Count - 1; last >= 0; last--)
                    if (Normalizing_List[last] != 0)
                        break;

                if (first == 0 && last == Normalizing_List.Count - 1)
                    return Normalizing_List;

                if (last - first > precition )
                {
                    first = last - precition;

                    if (Normalizing_List[first] > ((numeral_System + 1) / 2))
                    {
                        do
                        {
                            if (++first > last)
                            {
                                Normalizing_List = new List<byte>() { 1 };

                                Comma_Position++;

                                first = 1;

                                last = 1;
                            }
                            else
                                Normalizing_List[first]++;

                        } while (Normalizing_List[first] >= numeral_System);
                    }
                    else
                        first++;
                }

                if (first <= last)
                {
                    return Normalizing_List.GetRange(first, last - first + 1);
                }
                else
                {
                    Comma_Position = 0;

                    return new List<byte> { 0 };
                }
            }
        }
    }
}
