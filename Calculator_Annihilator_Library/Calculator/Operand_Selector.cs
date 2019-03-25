using System;

namespace Calculator_Annihilator_Library
{
	public partial class Calculator
	{
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
					return Addition(Number1.Value, Number2.Value);
				case Subtraction Sub:
					return Subtraction(Number1.Value, Number2.Value);
				case Multiplication Mult:
					return Multiplication(Number1.Value, Number2.Value);
				case Division Div:
					return Division(Number1.Value, Number2.Value);
				case Expontent Exp:
					return Exponentation(Number1.Value, Number2.Value);
				default:
					throw new NoActionOperationException();
			}
		}
	}
}
