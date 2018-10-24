﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	public partial class MainWindow
	{
		// Returns result of operation type as sign
		// Exceptios: DivideByZeroException, NoActionAsigned
		public static double Calc_Action_Selector(char sign, double number1, double number2)
		{
			switch (sign)
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
