using System;
using Calculator_Annihilator_Library;
using Xunit;

namespace Calculator_Annihilator_Library.Tests
{
    partial class Calculator_Tests
    {
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
    }
}