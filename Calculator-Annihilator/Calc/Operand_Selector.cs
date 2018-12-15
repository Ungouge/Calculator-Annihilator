using System;

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
		/// <exception cref="NoActionOperationException"></exception>
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
					return Division(number1, number2);
				case '^':
					return Exponentation(number1, number2);
				default:
					throw new NoActionOperationException();
			}
		}

		/// <summary>
		/// Returns result of operation of two given numbers
		/// </summary>
		/// <param name="_Operand">Whanted operation passed as Operand class</param>
		/// <param name="Number1">First number in operation</param>
		/// <param name="Number2">Seccond number in operation</param>
		/// <exception cref="DivideByZeroException"></exception>
		/// <exception cref="NoActionOperationException"></exception>
		public Number Operand_Selector(IOperand _Operand, INumber Number1, INumber Number2)
		{
			switch (_Operand)
			{
				case Addition Add:
					return new Number (Addition(Number1.Value, Number2.Value));
				case Subtraction Sub:
					return new Number(Subtraction(Number1.Value, Number2.Value));
				case Multiplication Mult:
					return new Number(Multiplication(Number1.Value, Number2.Value));
				case Division Div:
					return new Number(Division(Number1.Value, Number2.Value));
				case Expontent Exp:
					return new Number(Exponentation(Number1.Value, Number2.Value));
				default:
					throw new NoActionOperationException();
			}
		}
	}
}
