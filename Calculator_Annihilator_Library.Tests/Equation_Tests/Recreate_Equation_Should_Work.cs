using System;
using Xunit;
using Calculator_Annihilator_Library;
using Common_Library;

namespace Calculator_Annihilator_Library.Tests
{
    partial class Equation_Tests
    {
        /// <summary>
        /// Tests reading of text with equation of properly written equations.
        /// </summary>
        [Theory]

        [InlineData("5+2")]
        [InlineData("5*2")]
        [InlineData("5^2")]
        [InlineData("5+2*8")]
        [InlineData("(5,55615+2,1601)")]
        [InlineData("(5+2)*((74934/4535*345+4357)/(34^(5,433)))")]

        public void Recreate_Equation_Should_Work(string str)
        {
            _equation = new Equation(str, new Numeral_System(10));

            string actual = _equation.Recreate_Equation();

            Assert.Equal(actual, str);
        }
    }
}