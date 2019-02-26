using System;

namespace Calculator_Annihilator
{
	partial class Equation
	{
        /// <summary>
        /// Selects every character to organized as element list.
        /// </summary>
        private void Element_Selector()
        {
            if (the_Equation == default(string) || the_Equation == "")
            {
                Element_Colection.Add(new Number(0));

                return;
            }

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
		private bool Is_Operand(char sign)
		{
			for (int i = 0; i < Order_Of_Operations.operand_Sings.Length; i++)
				for (int k = 0; k < Order_Of_Operations.operand_Sings[i].Length; k++)
					if (Order_Of_Operations.operand_Sings[i][k] == sign)
					{
						Element_Colection.Add(Order_Of_Operations.Operands[i][k]);

						return true;
					}

			return false;
		}

		/// <summary>
		/// Returns end index of number whether given index is start of a number or do nothing if not. 
		/// </summary>
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
				Number Parsed_Number = _Parser.Parse( the_Equation.Substring(
                    first_Sign_Position, sign_Position - first_Sign_Position));

				Element_Colection.Add( Parsed_Number );

				return sign_Position;
			}
		}

		/// <summary>
		/// Finds index of last digit in number. 
		/// </summary>
		/// <param name="sign_Position">Index of first digit in number.</param>
		private int End_of_Number_Finder(int sign_Position)
		{
			for (int i = sign_Position; i < the_Equation.Length; i++)
			{
				if (Is_Comma(i) == true)
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
		private bool Is_Comma(int sign_Position)
		{
			foreach (string comma in Signs_Lib.Commas_Type)
            {
                int comma_Sign_Position = sign_Position;

                foreach (char comma_sign in comma)
                {
                    if(comma_Sign_Position < the_Equation.Length)
                    {
                        if (comma_sign != the_Equation[comma_Sign_Position++])
                            break;
                    }
                    else
                        break;

                    return true;
                }
            }

			return false;
		}

		/// <summary>
		/// Checks does given character is digit.
		/// </summary>
		/// <param name="sign">Character to check is digit.</param>
		private bool Is_Digit(char sign)
		{
			foreach (char digit in _Numerical_System.System_Digits)
				if (sign == digit)
					return true;

			return false;
		}
	}
}