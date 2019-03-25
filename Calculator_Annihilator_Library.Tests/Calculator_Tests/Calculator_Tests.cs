using System;
using Calculator_Annihilator_Library;
using Xunit;

namespace Calculator_Annihilator_Library.Tests
{
    public partial class Calculator_Tests
    {
        private readonly Calculator Calculator = new Calculator();

        public Number Arrange_Calculation(IOperand Operand, INumber Number1, INumber Number2)
        {
            // Act
            return Calculator.Operand_Selector(Operand, Number1, Number2);
        }
    }
}