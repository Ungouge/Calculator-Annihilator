using System;
using Xunit;

namespace Calculator_Annihilator.UTests
{
	/// <summary>
	/// Tests for basic calculation from Calc class.
	/// </summary>
	public class Calc_Test
	{
		Calculator Calculator = new Calculator();

		/// <summary>
		/// Cheks does addition is done properly to business logic.
		/// </summary>
		[Theory]

		[InlineData(2, 3, 5)]
		[InlineData(5e-1, 3e0, 35e-1)]
		[InlineData(0.11111, 0.22222, 0.33333)]
		[InlineData(Double.MaxValue, 116515e15, Double.MaxValue)]

		public void Addition_ShouldCaculate(double x, double y, double expected)
		{
			// Arrange
			Number Expected = new Number(expected);

			// Act
			Number Actual = Arrange_Calculation(new Addition(), new Number(x), new Number(y));

			// Assert
			Assert.Equal(Expected.Value, Actual.Value);
		}

		/// <summary>
		/// Cheks does subtraction is done properly to business logic.
		/// </summary>
		[Theory]

		[InlineData(2, -3, 5)]
		[InlineData(3e0, 5e-1, 25e-1)]
		[InlineData(Double.MinValue, 116515e15, Double.MinValue)]

		public void Subtraction_SouldCaculate(double x, double y, double expected)
		{
			// Arrange
			Number Expected = new Number(expected);

			// Act
			Number Actual = Arrange_Calculation(new Subtraction(), new Number(x), new Number(y));

			// Assert
			Assert.Equal(Expected.Value, Actual.Value);
		}

		/// <summary>
		/// Cheks does multiplication is done properly to business logic.
		/// </summary>
		[Theory]

		[InlineData(3, 2, 6)]
		[InlineData(3e-1, 5e-1, 15e-2)]
		[InlineData(0.11, 0.11, 0.0121)]
		[InlineData(Double.MaxValue, 1, Double.MaxValue)]

		public void Multiplication_SouldCaculate(double x, double y, double expected)
		{
			// Arrange
			Number Expected = new Number(expected);

			// Act
			Number Actual = Arrange_Calculation(new Multiplication(), new Number(x), new Number(y));

			// Assert
			Assert.Equal(Expected.Value, Actual.Value);
		}

		/// <summary>
		/// Cheks does divition is done properly to business logic.
		/// </summary>
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

			// Act
			Number Actual = Arrange_Calculation(new Division(), new Number(x), new Number(y));

			// Assert
			Assert.Equal(Expected.Value, Actual.Value);
		}

		/// <summary>
		/// Cheks does divition throws DivideByZeroException while dividing by zero according to business logic.
		/// </summary>

		[Theory]

		[InlineData(0)]
		[InlineData(1)]
		[InlineData(Double.MaxValue)]

		public void Divition_By_Zero_Exception_SouldCaculate(double x)
		{
			// Assert
			Assert.Throws<DivideByZeroException>(() => Calculator.Operand_Selector(new Division(), new Number(x), new Number(0)));
		}

		/// <summary>
		/// Cheks does powers is done properly to business logic.
		/// </summary>
		[Theory]

		[InlineData(2, 2, 4)]
		[InlineData(5, 1, 5)]
		[InlineData(10000, 0.25, 10)]
		[InlineData(Double.MaxValue, 116515e15, Double.PositiveInfinity)]

		public void Exponentation_SouldCaculate(double x, double y, double expected)
		{
			// Arrange
			Number Expected = new Number(expected);

			// Act
			Number Actual = Arrange_Calculation(new Expontent(), new Number(x), new Number(y));

			// Assert
			Assert.Equal(Expected.Value, Actual.Value);
        }

        public Number Arrange_Calculation(IOperand Operand, INumber Number1, INumber Number2)
        {
            // Act
            return Calculator.Operand_Selector(Operand, Number1, Number2);
        }
    }
}