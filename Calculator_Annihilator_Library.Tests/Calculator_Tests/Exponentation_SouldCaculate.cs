using System;
using Calculator_Annihilator_Library;
using Xunit;

namespace Calculator_Annihilator_Library.Tests
{
    partial class Calculator_Tests
    {
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
    }
}