using System;
using System.Windows;

namespace Calculator_Annihilator
{
	/// <summary>
	/// Class for parsing text to number or digits in current numeral system
	/// </summary>
	public class Parser
	{
		/// <summary>
		/// Converts the string representation of a number in given numeral system to its
		/// double-precision floating-point number equivalent.
		/// </summary>
		/// <param name="work_Text">String to convert</param>
		/// <param name="_Numeral_System">Convert to this numeral system</param>
		public Number Parse(string work_Text, Numeral_System _Numeral_System)
		{
			int commaPosition = Comma_Position(work_Text);

			double parsedOutput = 0;

			for (int i = 0; i < commaPosition; i++) //parsing numbers highier than zero
			{
				try
				{
					parsedOutput +=
                        DigitParse(work_Text[i], _Numeral_System) * Math.Pow(_Numeral_System.System_Type, commaPosition - i - 1);
				}
				catch (Exception ex)
				{
					parsedOutput = parsedOutput * Math.Pow(_Numeral_System.System_Type, i - commaPosition);
					MessageBox.Show(ex.Message + $", {work_Text} parsed as {parsedOutput}.");
					return new Number(parsedOutput);
				}
			}

			for (int i = commaPosition + 1; i < work_Text.Length; i++) //parsing numbers lower than zero
			{
				try
				{
					parsedOutput +=
                        DigitParse(work_Text[i], _Numeral_System) * Math.Pow(_Numeral_System.System_Type, commaPosition - i);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message + $", {work_Text} parsed as {parsedOutput}.");
				}
			}

			return new Number (parsedOutput);
		}

		/// <summary>
		/// Cheks does comma ocurs in converting string, returns its position (if there is none in string return length
		/// of string that corresponds to dummy position of comma in number).
		/// </summary>
		private static int Comma_Position(string work_Text)
		{
			for (int i = 0; i < work_Text.Length; i++)
				foreach (char comma in Signs_Lib.CommasType)
					if (comma == work_Text[i])
						return i;

			return work_Text.Length;
		}

		/// <summary>
		/// Converts the character representation of a number in given numeral system to its
		/// signed byte number equivalent.
		/// </summary>
		/// <exception cref="ParsingCharacterIsNoDigitException">
		/// The Exception that is thrown when character that is to be parsed to digit is corresponding
		///  no digit from current numerical system.
		/// </exception>
		public sbyte DigitParse(char digit, Numeral_System _Numeral_System)
		{
			if (digit > (char)47 && digit < (char)58 && digit < _Numeral_System.System_Type + 48)
				return (sbyte)(digit - 48);
			else if (digit > (char)64 && digit < (char)91 && digit < _Numeral_System.System_Type + 55) // not tested from this point
				return (sbyte)(digit - 55); // 'A' = 10 - 'Z' 35
			else if (digit > (char)96 && digit < (char)121 && digit < _Numeral_System.System_Type + 51)
				return (sbyte)(digit - 51); // 'a' = 36 - 'x' = 59 
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
//'W' = 31
//'V' = 32
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
//'w' = 57
//'v' = 58
//'x' = 59