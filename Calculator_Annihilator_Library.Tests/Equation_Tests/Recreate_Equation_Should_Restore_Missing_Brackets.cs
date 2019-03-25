using System;
using Xunit;
using Calculator_Annihilator_Library;
using Common_Library;

namespace Calculator_Annihilator_Library.Tests
{
    partial class Equation_Tests
    {
        /// <summary>
        /// Tests reading of text with equation which  missing brackets
        /// and checks do brackets are added properly according to business logic.
        /// </summary>
        [Theory]

        [InlineData("5,55615+2,1601)", "(5,55615+2,1601)")]
        [InlineData("5+2)*((7/4)-(3*7)", "(5+2)*((7/4)-(3*7))")]
        [InlineData("(5+2)*((7/4*3+7)/(4^(5,3)", "(5+2)*((7/4*3+7)/(4^(5,3)))")]
        [InlineData("(4^(5+3", "(4^(5+3))")]
        [InlineData("5*((5+2)*(4^(5,3)", "5*((5+2)*(4^(5,3)))")]

        public void Recreate_Equation_Should_Restore_Missing_Brackets(string str, string expected)
        {
            _equation = new Equation(str, new Numeral_System(10));

            string actual = _equation.Recreate_Equation();

            Assert.Equal(expected, actual);
        }
    }
}