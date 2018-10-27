using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator_Annihilator
{
	public class Parser
	{
		public double Parse(string workText, sbyte Numeral_System)
		{
			char[] workCharArr = workText.ToCharArray();

			int commaPosition = Comma_Position(workCharArr);

			double parsedOutput = 0;

			for (int i = 0; i < commaPosition; i++) //parsing numbers highier than zero
			{
				try
				{
					parsedOutput += DigitParse(workCharArr[i], Numeral_System) * Math.Pow(Numeral_System, commaPosition - i - 1);
				}
				catch (Exception ex)
				{
					parsedOutput = parsedOutput * Math.Pow(Numeral_System, i - commaPosition);
					MessageBox.Show(ex.Message + $", {workText} parsed as {parsedOutput}.");
					return parsedOutput;
				}
			}

			for (int i = commaPosition + 1; i < workCharArr.Length; i++) //parsing numbers lower than zero
			{
				try
				{
					parsedOutput += DigitParse(workCharArr[i], Numeral_System) * Math.Pow(Numeral_System, commaPosition - i);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message + $", {workText} parsed as {parsedOutput}.");
				}
			}

			return parsedOutput;
		}

		private static int Comma_Position(char[] workCharArr)
		{

			for (int i = 0; i < workCharArr.Length; i++)
			{
				switch (workCharArr[i])
				{
					case ',':
					case '.':
					case '٫':
						return i;
				}
			}

			return workCharArr.Length;
		}

		public sbyte DigitParse(char digit, sbyte Numeral_System)
		{
			if (digit > (char)47 && digit < (char)58 && digit < Numeral_System + 48)
				return (sbyte)(digit - 48);
			else if (digit > (char)64 && digit < (char)91 && digit < Numeral_System + 55) // not tested from this point
				return (sbyte)(digit - 55); // 'A' = 10 - 'Z' 35
			else if (digit > (char)96 && digit < (char)121 && digit < Numeral_System + 51)
				return (sbyte)(digit - 51); // 'a' = 36 - 'x' =59 
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