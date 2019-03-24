using System;
using System.Collections.Generic;

namespace Calculator_Annihilator_Library
{
    partial class Back_Parser_Fascede
    {
        partial class Positional_Back_Parser
        {
            /// <summary>
            /// Converts given digit list to string number in current numeral system. 
            /// </summary>
            private string Digit_List_In_Numeral_System_To_String(List<byte> Digit_List)
            {
                List<byte> _Digit_List = Digit_List.GetRange(0, Digit_List.Count);
                if (_Digit_List.Count > 0)
                    _Digit_List.Reverse();

                string output = default(string);

                foreach (byte digit_byte in _Digit_List)
                {
                    if (digit_byte < numeral_System_Type)
                    {
                        if (digit_byte < 10)
                            output += Convert.ToChar(digit_byte + 48);
                        else if (digit_byte < 36)
                            output += Convert.ToChar(digit_byte + 55); // 'A' = 10 - 'Z' 35
                        else if (digit_byte < 65)
                            output += Convert.ToChar(digit_byte + 61); // 'a' = 36 - 'z' = 61, '}' = 62, '|' =  63
                        
                        else
                            throw new Exception($"{digit_byte.ToString()} is out off numeral system");
                    }
                }

                return output;
            }
        }
    }
}
//'A' = 10
//'B' = 11
//'C' = 12
//'D' = 13
//'E' = 14
//'F' = 15
//'G' = 16
//'H' = 17
//'I' = 18
//'J' = 19
//'K' = 20
//'L' = 21
//'M' = 22
//'N' = 23
//'O' = 24
//'P' = 25
//'Q' = 26
//'R' = 27
//'S' = 29
//'T' = 29
//'U' = 30
//'V' = 31
//'W' = 32
//'X' = 33
//'Y' = 34
//'Z' = 35
//'a' = 36
//'b' = 37
//'c' = 38
//'d' = 39
//'e' = 40
//'f' = 41
//'g' = 42
//'h' = 43
//'i' = 44
//'j' = 45
//'k' = 46
//'l' = 47
//'m' = 48
//'n' = 49
//'o' = 50
//'p' = 51
//'q' = 52
//'r' = 53
//'s' = 54
//'t' = 55
//'u' = 56
//'v' = 57
//'w' = 58
//'x' = 59
//'y' = 60
//'z' = 61
//'}' = 62
//'|' = 63