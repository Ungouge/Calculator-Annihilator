using System;
using Common_Library;
using Message_Popupper;

namespace Calculator_Annihilator_Library
{
	partial class Parser
	{
		/// <summary>
		/// Converts the string representation of a number in given numeral system to its
		/// double-precision floating-point number equivalent.
		/// </summary>
		/// <param name="work_Text">String to convert</param>
		public Number Parse(string work_Text)
		{
			int comma_Position = Comma_Position(work_Text);

            bool is_Negative = false;

			double parsed_Output = 0;

            if (work_Text[0] == '-')
                is_Negative = true;

			for (int i = ( is_Negative ? 1 : 0) ; i < comma_Position; i++) //parsing numbers highier than zero
			{
				try
				{
					parsed_Output +=
                        Digit_Parse(work_Text[i], Numeral_System) * Math.Pow(
                            Numeral_System.System_Type, comma_Position - i - 1);
				}
				catch (Exception ex)
				{
					parsed_Output = parsed_Output * Math.Pow(Numeral_System.System_Type, i - comma_Position);

                    parsed_Output = Recognize_Negative_Sign(parsed_Output, is_Negative);

                    IMessage_Box Message_Box = Factory.Get_Message_Box;

                    Message_Box.Pop_Up(ex.Message + $", {work_Text} parsed as {parsed_Output}.");

					return new Number( parsed_Output);
				}
			}

			for (int i = comma_Position + 1; i < work_Text.Length; i++) //parsing numbers lower than zero
			{
				try
				{
					parsed_Output +=
                        Digit_Parse(work_Text[i], Numeral_System) * Math.Pow(
                            Numeral_System.System_Type, comma_Position - i);
				}
				catch (Exception ex)
                {
                    parsed_Output = Recognize_Negative_Sign(parsed_Output, is_Negative);

                    IMessage_Box Message_Box = Factory.Get_Message_Box;

                    Message_Box.Pop_Up(ex.Message + $", {work_Text} parsed as {parsed_Output}.");

                    return new Number(parsed_Output);
                }
			}

            parsed_Output = Recognize_Negative_Sign(parsed_Output, is_Negative);

            return new Number (parsed_Output);
		}

		/// <summary>
		/// Cheks does comma ocurs in converting string, returns its position (if there is none in string return length
		/// of string that corresponds to dummy position of comma in number).
		/// </summary>
		private int Comma_Position(string work_Text)
		{
            for (int i = 0; i < work_Text.Length; i++)
            {
                foreach (string comma in Commas_Type)
                {
                    int j = i;

                    foreach (char comma_sign in comma)
                    {
                        if (j < work_Text.Length)
                        {
                            if (comma_sign != work_Text[j++])
                                break;
                        }
                        else
                            break;

                        return i;
                    }
                }
            }

			return work_Text.Length;
		}

        /// <summary>
        /// Recognizes does number is flaged as negative, if so returns it as negative
        /// </summary>
        private double Recognize_Negative_Sign(double parsed_Output, bool isNegative)
        {
            return isNegative ? parsed_Output * -1e0 : parsed_Output;
        }

		/// <summary>
		/// Converts the character representation of a number in given numeral system to its
		/// signed byte number equivalent.
		/// </summary>
		/// <exception cref="ParsingCharacterIsNoDigitException">
		/// The Exception that is thrown when character that is to be parsed to digit is corresponding
		///  no digit from current numerical system.
		/// </exception>
		public sbyte Digit_Parse(char digit, Numeral_System _Numeral_System)
		{
			if (digit >= '0' && digit <= '9' && digit < _Numeral_System.System_Type + 48)
				return (sbyte)(digit - '0');
			else if (digit >= 'A' && digit <= 'Z' && digit < _Numeral_System.System_Type + 55)
				return (sbyte)(digit - 55); // 'A' = 10 - 'Z' 35
			else if (digit >= 'a' && digit <= '|' && digit < _Numeral_System.System_Type + 61)
				return (sbyte)(digit - 61); // 'a' = 36 - 'z' = 61, '}' = 62, '|' =  63
            else
				throw new ParsingCharacterIsNoDigitException($"{digit} is not a digit");
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