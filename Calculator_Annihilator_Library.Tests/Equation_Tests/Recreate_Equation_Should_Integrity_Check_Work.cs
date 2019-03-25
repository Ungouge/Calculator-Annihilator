using System;
using Xunit;
using Calculator_Annihilator_Library;
using Common_Library;

namespace Calculator_Annihilator_Library.Tests
{
    partial class Equation_Tests
    {
        /// <summary>
        /// Tests reading of text with equation with some mistakes made and check do they are repair according to business logic.
        /// </summary>
        [Theory]

        [InlineData(")+2)*(7/4*3+7)", "(2)*(7/4*3+7)")] // wrong signs in the beging of equaton
        [InlineData("(7/4*3+7)*(/(--(*(*", "(7/4*3+7)")] // wrong signs at the end of equaton
        [InlineData("(7/4*3+7)*)/)--)*)*", "(7/4*3+7)")] // wrong signs at the end of equaton
        [InlineData("(5+2)(7/4*3+7)", "(5+2)*(7/4*3+7)")] // missing multiplication symbol between brackets
        [InlineData("2(7/4*3+7)", "2*(7/4*3+7)")] // missing multiplication symbol between bracket and number
        [InlineData("5+()2", "5+2")] // empty bracket
        [InlineData("5+()/2", "5+2")] // empty bracket and naother operand
        [InlineData("6-6--658", "6-6-658")] // few operands in row
        [InlineData("(+)*)/)--)*)*", "0")] // everything wrong


        public void Recreate_Equation_Should_Integrity_Check_Work(string str, string expected)
        {
            _equation = new Equation(str, new Numeral_System(10));

            string actual = _equation.Recreate_Equation();

            Assert.Equal(expected, actual);
        }
    }
}