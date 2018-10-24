using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	public partial class MainWindow
	{
		private static double Exponentation(double number1, double number2)
		{
			return Math.Pow(number1, number2);
		}

		private static double Subtraction(double number1, double number2)
		{
			return number1 - number2;
		}

		private static double Addition(double number1, double number2)
		{
			return number1 + number2;
		}

		private static double Divition(double number1, double number2)
		{
			if (number2 == 0)
				throw new DivideByZeroException();
			else
				return number1 / number2;
		}

		private static double Multiplication(double number1, double number2)
		{
			return number1 * number2;
		}
	}
}
