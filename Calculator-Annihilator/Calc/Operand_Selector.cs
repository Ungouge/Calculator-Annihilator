using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	public partial class Calc
	{
		/// <summary>
		/// Returns result of operation type as operand_Sign
		/// </summary>
		/// <param name="operand_Sign">Whanted operation passed as character</param>
		/// <param name="number1">First number in operation</param>
		/// <param name="number2">Seccond number in operation</param>
		/// <exception cref="DivideByZeroException"></exception>
		/// <exception cref="NoActionAsigned"></exception>
		public double Operand_Selector(char operand_Sign, double number1, double number2)
		{
			switch (operand_Sign)
			{
				case '+':
					return Addition(number1, number2);
				case '-':
					return Subtraction(number1, number2);
				case '*':
					return Multiplication(number1, number2);
				case '/':
					return Divition(number1, number2);
				case '^':
					return Exponentation(number1, number2);
				default:
					throw new NoActionAsigned();
			}
		}
	}
}
