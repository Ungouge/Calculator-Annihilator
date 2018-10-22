using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Anihilator
{
	public partial class MainWindow
	{
		public double Calc_Action_Selector(char sign, double number1, double number2)
		{
			switch (sign)
			{
				case '^':
					return Math.Pow(number1,number2);
				case '*':
					return number1 * number2;
				case '/':
					{
						if (number2 == 0)
							throw new DivideByZeroException();
						else
							return number1 / number2;
					}
				case '+':
					return number1 + number2;
				case '-':
					return number1 - number2;
				default:
					throw new NoActionAsigned();
			}
		}
	}
}
