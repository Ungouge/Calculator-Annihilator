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
	partial class Equation
	{
		// xyz: check does return type is better.
		private void Element_Selector(string equation)
		{
			for (int i = 0; i < equation.Length; i++)
			{
				Element_Segregator(equation, ref i);
			}
		}

		private void Element_Segregator(string equation, ref int sign_Position)
		{
			int sign_Holder = End_Number(equation, sign_Position);

			if ( sign_Holder!= sign_Position)
			{
				sign_Position = sign_Holder-1;
				return;
			}

			char sign = equation[sign_Position];

			if (Is_Operand(sign) == true)
				return;

			if (Is_Bracket(sign) == true)
				return;
		}

		private bool Is_Bracket(char sign)
		{
			if (sign == '(')
			{
				Elements_Colection.Add( new Open_Bracket());
				return true;
			}

			if (sign == ')')
			{
				Elements_Colection.Add( new Close_Bracket());
				return true;
			}

			return false;
		}

		private bool Is_Operand(char sign)
		{
			for (int i = 0; i < Signs_Lib.operand_Sings.Length; i++)
				for (int k = 0; k < Signs_Lib.operand_Sings[i].Length; k++)
					if (Signs_Lib.operand_Sings[i][k] == sign)
					{
						Elements_Colection.Add( Signs_Lib.Operands[i][k]);
						return true;
					}

			return false;
		}

		private int End_Number(string equation, int first_Sign_Position)
		{
			int sign_Position = first_Sign_Position;

			sign_Position = End_of_Number_Finder(equation, sign_Position);

			if (first_Sign_Position == sign_Position)
			{
				//MessageBox.Show($" Not parsed {equation[sign_Position]}");
				return sign_Position;
			}
			else
			{
				double d = _Parser.Parse(equation.Substring(first_Sign_Position, sign_Position - first_Sign_Position), _Numerical_System.System_Type);
				//MessageBox.Show($"Parsed {d.ToString()}");
				Elements_Colection.Add( new Number(d));
				return sign_Position;
			}
		}

		private int End_of_Number_Finder(string equation, int sign_Position)
		{
			for (int i = sign_Position; i < equation.Length; i++)
			{
				if (Is_Comma(equation[i]) == true)
					continue;
				else if (Is_Digit(equation[i]) == true)
					continue;
				else
					return i;
			}

			return equation.Length;
		}

		private bool Is_Comma(char sign)
		{
			foreach (char comma in Signs_Lib.CommasType)
				if (sign == comma)
					return true;

			return false;
		}

		private bool Is_Digit(char sign)
		{
			foreach (char digit in _Numerical_System.System_Digits)
				if (sign == digit)
					return true;

			return false;
		}
	}
}
