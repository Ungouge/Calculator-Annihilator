using System;
using Xunit;
using Common_Library;

namespace Calculator_Annihilator_Library.Tests
{
    partial class Equation_Solving_Test
    {
        /// <summary>
        /// Tests equation without brackets.
        /// </summary>
        [Theory]

        [InlineData("5+2", 7)]
        [InlineData("5+2*8", 21)]
        [InlineData("5^2/12,5", 2)]

        public void No_Bracket_Solving_Should_Work(string str, double expected)
        {
            _equation = new Equation(str, new Numeral_System(10));

            double actual = _equation.Solved_Value;

            //Assert.True(expected == actual);
            Assert.Equal(expected, actual);
        }
    }
}
