using System;
using Xunit;
using Common_Library;

namespace Calculator_Annihilator_Library.Tests
{
    partial class Equation_Solving_Test
    {
        /// <summary>
        /// Tests equation with brackets.
        /// </summary>
        [Theory]

        [InlineData("(5+2)*3", 21)]
        [InlineData("(5+2)*((7/4)+(3*7))", 159.25)]
        [InlineData("(5+2)*(7/4*3+7)", 85.75)]
        [InlineData("(5+2)^(3/2)*(7/4*3+7)", 226.873174923789)]

        public void With_Bracket_Solving_Should_Work(string str, double expected)
        {
            _equation = new Equation(str, new Numeral_System(10));

            double actual = _equation.Solved_Value;

            //Assert.True(expected == actual);
            Assert.Equal(expected.ToString(), actual.ToString());
        }
    }
}
