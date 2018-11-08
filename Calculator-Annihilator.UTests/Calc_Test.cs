using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator_Annihilator;
using Xunit;

namespace Calculator_Annihilator.UTests
{
	public class Calc_Test
	{
		Calc calc = new Calc();
		[Theory]

		[InlineData(2, 3, 5)]
		[InlineData(5e-1, 3e0, 35e-1)]
		[InlineData(0.11111, 0.22222, 0.33333)]
		[InlineData(Double.MaxValue, 116515e15, Double.MaxValue)]

		public void Addition_ShouldCaculate(double x, double y, double expected)
		{
			// Arrange
			Number Expected = new Number(expected);
			Operand _Operand = new Operand('+');

			// Act
			double actual = calc.Operand_Selector('+', x, y);
			Number Actual = calc.Operand_Selector(_Operand, new Number(x), new Number(y));

			// Assert
			Assert.Equal(expected, actual);
			Assert.Equal(Expected.Value, Actual.Value);
		}

		[Theory]

		[InlineData(2, -3, 5)]
		[InlineData(3e0, 5e-1, 25e-1)]
		[InlineData(Double.MinValue, 116515e15, Double.MinValue)]

		public void Subtraction_SouldCaculate(double x, double y, double expected)
		{
			// Arrange
			Number Expected = new Number(expected);
			Operand _Operand = new Operand('-');

			// Act
			double actual = calc.Operand_Selector('-', x, y);
			Number Actual = calc.Operand_Selector(_Operand, new Number(x), new Number(y));

			// Assert
			Assert.Equal(expected, actual);
			Assert.Equal(Expected.Value, Actual.Value);
		}

		[Theory]

		[InlineData(3, 2, 6)]
		[InlineData(3e-1, 5e-1, 15e-2)]
		[InlineData(0.11, 0.11, 0.0121)]
		[InlineData(Double.MaxValue, 1, Double.MaxValue)]

		public void Multiplication_SouldCaculate(double x, double y, double expected)
		{
			// Arrange
			Number Expected = new Number(expected);
			Operand _Operand = new Operand('*');

			// Act
			double actual = calc.Operand_Selector('*', x, y);
			Number Actual = calc.Operand_Selector(_Operand, new Number(x), new Number(y));

			// Assert
			Assert.Equal(expected, actual);
			Assert.Equal(Expected.Value, Actual.Value);
		}

		[Theory]

		[InlineData(6, 2, 3)]
		[InlineData(3e0, 5e-1, 6e0)]
		[InlineData(0.0121, 0.11, 0.11)]
		[InlineData(Double.MaxValue, 1, Double.MaxValue)]
		[InlineData(Double.MaxValue, Double.MaxValue, 1)]

		public void Divition_SouldCaculate(double x, double y, double expected)
		{
			// Arrange
			Number Expected = new Number(expected);
			Operand _Operand = new Operand('/');


			// Act
			double actual = calc.Operand_Selector('/', x, y);
			Number Actual = calc.Operand_Selector(_Operand, new Number(x), new Number(y));

			// Assert
			Assert.Equal(expected, actual);
			Assert.Equal(Expected.Value, Actual.Value);
		}

		[Theory]

		[InlineData(0)]
		[InlineData(1)]
		[InlineData(Double.MaxValue)]

		public void Divition_By_Zero_Exception_SouldCaculate(double x)
		{
			// Assert
			Assert.Throws<DivideByZeroException>(() => calc.Operand_Selector('/', x, 0));
			Assert.Throws<DivideByZeroException>(() => calc.Operand_Selector(new Operand('/'), new Number(x), new Number(0)));
		}

		[Theory]

		[InlineData(2, 2, 4)]
		[InlineData(5, 1, 5)]
		[InlineData(10000, 0.25, 10)]
		[InlineData(Double.MaxValue, 116515e15, Double.PositiveInfinity)]

		public void Exponentation_SouldCaculate(double x, double y, double expected)
		{
			// Arrange
			Number Expected = new Number(expected);
			Operand _Operand = new Operand('^');

			// Act
			double actual = calc.Operand_Selector('^', x, y);
			Number Actual = calc.Operand_Selector(_Operand, new Number(x), new Number(y));

			// Assert
			Assert.Equal(expected, actual);
			Assert.Equal(Expected.Value, Actual.Value);
		}
	}
}