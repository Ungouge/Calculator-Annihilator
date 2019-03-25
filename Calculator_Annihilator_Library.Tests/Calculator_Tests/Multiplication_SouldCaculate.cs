using System;
using Calculator_Annihilator_Library;
using Xunit;

namespace Calculator_Annihilator_Library.Tests
{
    partial class Calculator_Tests
    {
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
    }
}