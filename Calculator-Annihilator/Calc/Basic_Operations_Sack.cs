using System;

namespace Calculator_Annihilator
{
	/// <summary>
	/// Class with methods for single calculations.
	/// </summary>
	partial class Calc
	{
		/// <summary>
		/// Calculates and returns result of power. 
		/// </summary>
		private double Exponentation(double base_, double exponent)
		{
			return Math.Pow(base_, exponent);
		}

		/// <summary>
		/// Calculates and returns result of division.
		/// </summary>
		/// <exception cref="DivideByZeroException"></exception>
		private double Division(double divident, double divition)
		{
			if (divition == 0)
				throw new DivideByZeroException();
			else
				return divident / divition;
		}

		/// <summary>
		/// Calculates and returns result of multiplication.
		/// </summary>
		private double Multiplication(double factor1, double factor2)
		{
			return factor1 * factor2;
		}

		/// <summary>
		/// Calculates and returns result of subtraction.
		/// </summary>
		private double Subtraction(double minuend, double subtrahend)
		{
			return minuend - subtrahend;
		}

		/// <summary>
		/// Calculates and returns result of addition.
		/// </summary>
		private double Addition(double summand1, double summand2)
		{
			return summand1 + summand2;
		}
	}
}
