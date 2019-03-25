using System;
using Calculator_Annihilator_Library;
using Xunit;

namespace Calculator_Annihilator_Library.Tests
{
    partial class Calculator_Tests
    {
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
    }
}