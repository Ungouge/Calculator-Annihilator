using System;

namespace Calculator_Annihilator_Library
{
	/// <summary>
	/// Class with methods for single calculations.
	/// </summary>
	partial class Calculator
	{
		/// <summary>
		/// Calculates and returns result of power. 
		/// </summary>
		private Number Exponentation(double base_, double exponent)
		{
			return new Number(Math.Pow(base_, exponent));
		}

		/// <summary>
		/// Calculates and returns result of division.
		/// </summary>
		/// <exception cref="DivideByZeroException"></exception>
		private Number Division(double divident, double divition)
		{
			if (divition == 0)
				throw new DivideByZeroException();
			else
				return new Number(divident / divition);
		}

		/// <summary>
		/// Calculates and returns result of multiplication.
		/// </summary>
		private Number Multiplication(double factor1, double factor2)
		{
			return new Number(factor1 * factor2);
		}

		/// <summary>
		/// Calculates and returns result of subtraction.
		/// </summary>
		private Number Subtraction(double minuend, double subtrahend)
		{
			return new Number(minuend - subtrahend);
		}

		/// <summary>
		/// Calculates and returns result of addition.
		/// </summary>
		private Number Addition(double summand1, double summand2)
		{
			return new Number(summand1 + summand2);
		}
	}
}
