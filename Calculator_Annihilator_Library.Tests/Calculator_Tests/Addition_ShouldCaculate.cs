using System;
using Xunit;

namespace Calculator_Annihilator_Library.Tests
{
    partial class Calculator_Tests
    {
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
    }
}