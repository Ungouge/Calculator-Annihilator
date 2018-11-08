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
		/// Returns result of operation of two given numbers
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

		/// <summary>
		/// Returns result of operation of two given numbers
		/// </summary>
		/// <param name="_Operand">Whanted operation passed as Operand class</param>
		/// <param name="Number1">First number in operation</param>
		/// <param name="Number2">Seccond number in operation</param>
		/// <exception cref="DivideByZeroException"></exception>
		/// <exception cref="NoActionAsigned"></exception>
		public Number Operand_Selector(IOperand _Operand, INumber Number1, INumber Number2)
		{
			switch (_Operand.Sign)
			{
				case '+':
					return new Number (Addition(Number1.Value, Number2.Value));
				case '-':
					return new Number(Subtraction(Number1.Value, Number2.Value));
				case '*':
					return new Number(Multiplication(Number1.Value, Number2.Value));
				case '/':
					return new Number(Divition(Number1.Value, Number2.Value));
				case '^':
					return new Number(Exponentation(Number1.Value, Number2.Value));
				default:
					throw new NoActionAsigned();
			}
		}
	}
}
