using System;
using Xunit;

namespace Calculator_Annihilator_Library.Tests
{
    partial class Calculator_Tests
    {
        /// <summary>
        /// Cheks does divition throws DivideByZeroException while dividing by zero according to business logic.
        /// </summary>

        [Theory]

        [InlineData(0)]
        [InlineData(1)]
        [InlineData(Double.MaxValue)]

        public void Divition_By_Zero_Exception_Sould_Throw_Exception(double x)
        {
            // Assert
            Assert.Throws<DivideByZeroException>(() => Calculator.Operand_Selector(new Division(), new Number(x), new Number(0)));
        }
    }
}