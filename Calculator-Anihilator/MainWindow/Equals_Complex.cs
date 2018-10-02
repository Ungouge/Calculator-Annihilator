using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Anihilator
{
	public partial class MainWindow
	{
		private double Equals_Complex(string equation)
		{
			return 0e0;
			/*int actionSingsIndex = equation.LastIndexOfAny(actionSings);
			if (actionSingsIndex >= 0)
			{
				double? number1 = Equals_Complex(equation.Substring(0, actionSingsIndex));
				double? number2 = Equals_Complex(equation.Substring(actionSingsIndex + 1));
				char sign = (char)equation[actionSingsIndex];
				switch (sign)
				{
					case '+':
						return number1 + number2;
					case '-':
						return number1 - number2;
					case '*':
						return number1 * number2;
					case '/':
						return number1 / number2;
				}
			}
			else
			{
				if (double.TryParse(equation, out double number))
					return number;
				else return null;
			}
			return null;*/
		}
	}
}
