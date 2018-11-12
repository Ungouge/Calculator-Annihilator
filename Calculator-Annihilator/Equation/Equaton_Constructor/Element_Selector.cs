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
		/// <summary>
		/// Selects every character to organized as element list.
		/// </summary>
		private void Element_Selector()
		{
			for (int i = 0; i < the_Equation.Length; i++)
			{
				i = Element_Segregator(i);
			}
		}

		/// <summary>
		/// Enlists given position in equation as element. Returns index of last character in element.
		/// </summary>
		/// <param name="sign_Index">Index of character to be assigned as element</param>
		private int Element_Segregator(int sign_Index)
		{
			int end_Number_Index = End_Number(sign_Index);

			if ( end_Number_Index != sign_Index)
			{
				sign_Index = end_Number_Index-1;
				return sign_Index;
			}

			char sign = the_Equation[sign_Index];

			if (Is_Operand(sign) == true)
				return sign_Index;

			if (Is_Bracket(sign) == true)
				return sign_Index;

			return sign_Index;
		}

		/// <summary>
		/// Checks does given character is bracket.
		/// </summary>
		/// <param name="sign">Character to check is bracket.</param>
		private bool Is_Bracket(char sign)
		{
			if (sign == '(')
			{
				Element_Colection.Add( new Open_Bracket());
				return true;
			}

			if (sign == ')')
			{
				Element_Colection.Add( new Close_Bracket());
				return true;
			}

			return false;
		}

		/// <summary>
		/// Checks does given character is operand.
		/// </summary>
		/// <param name="sign">Character to check is operand.</param>
		/// <returns></returns>
		private bool Is_Operand(char sign)
		{
			for (int i = 0; i < Signs_Lib.operand_Sings.Length; i++)
				for (int k = 0; k < Signs_Lib.operand_Sings[i].Length; k++)
					if (Signs_Lib.operand_Sings[i][k] == sign)
					{
						Element_Colection.Add( Signs_Lib.Operands[i][k]);
						return true;
					}

			return false;
		}

		/// <summary>
		/// Returns end index of number whether given index is start of a number or do nothing if not. 
		/// </summary>
		/// <param name="first_Sign_Position"></param>
		/// <returns></returns>
		private int End_Number(int first_Sign_Position)
		{
			int sign_Position = first_Sign_Position;

			sign_Position = End_of_Number_Finder(sign_Position);

			if (first_Sign_Position == sign_Position)
			{
				return sign_Position;
			}
			else
			{
				Number Parsed_Number = _Parser.Parse(the_Equation.Substring(first_Sign_Position, sign_Position - first_Sign_Position), _Numerical_System);
				Element_Colection.Add( Parsed_Number );
				return sign_Position;
			}
		}

		/// <summary>
		/// Finds index of last digit in number. 
		/// </summary>
		/// <param name="sign_Position">Index of first digit in number.</param>
		/// <returns></returns>
		private int End_of_Number_Finder(int sign_Position)
		{
			for (int i = sign_Position; i < the_Equation.Length; i++)
			{
				if (Is_Comma(the_Equation[i]) == true)
					continue;
				else if (Is_Digit(the_Equation[i]) == true)
					continue;
				else
					return i;
			}

			return the_Equation.Length;
		}

		/// <summary>
		/// Checks does given character is comma.
		/// </summary>
		/// <param name="sign">Character to check is comma.</param>
		/// <returns></returns>
		private bool Is_Comma(char sign)
		{
			foreach (char comma in Signs_Lib.CommasType)
				if (sign == comma)
					return true;

			return false;
		}

		/// <summary>
		/// Checks does given character is digit.
		/// </summary>
		/// <param name="sign">Character to check is digit.</param>
		/// <returns></returns>
		private bool Is_Digit(char sign)
		{
			foreach (char digit in _Numerical_System.System_Digits)
				if (sign == digit)
					return true;

			return false;
		}
	}
}
