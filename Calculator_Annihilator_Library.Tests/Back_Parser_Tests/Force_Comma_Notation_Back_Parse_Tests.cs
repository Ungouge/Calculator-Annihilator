using System;
using Common_Library;
using Xunit;
using Assert = Xunit.Assert;

namespace Calculator_Annihilator_Library.Tests
{
    public class Force_Comma_Notation_Back_Parse_Tests
    {
        private Back_Parser_Fascede Back_Parser;

        /// <summary>
        /// Returns given number in given numeral system as string representation in
        /// notation forcing usage of comma.
        /// </summary>
        public string Back_Parse_Radix_Base_Comma_Mock_Test(double number, sbyte numeral_System_Type)
        {
            Back_Parser = new Back_Parser_Fascede(Number_Notation.Force_Radix_Base, numeral_System_Type, ",");

            // Act

            INumber Number = new Number(number);

            return Back_Parser.Parse_Back(Number);
        }

        /// <summary>
        /// Tests back parsing numbers to decimal representations of radix base notation.
        /// </summary>
        [Theory]
        [InlineData(1e0, "1")]
        [InlineData(11e-1, "1,1")]
        [InlineData(95E-11, "0,00000000095")]
        [InlineData(1e1, "10")]
        [InlineData(1e-1, "0,1")]
        [InlineData(123456e-6, "0,123456")]
        [InlineData(123456e6, "123456000000")]
        [InlineData(987654321e20, "98765432100000000000000000000")]
        [InlineData(987654321e-5, "9876,54321")]
        [InlineData(-987654321e-5, "-9876,54321")]
        [InlineData(123456789e-21, "0,000000000000123456789")]
        public void Back_Parse_Decimal(double number, string expected_Output)
        {
            // Arrange & Act

            string output = Back_Parse_Radix_Base_Comma_Mock_Test(number, 10);

            // Assert

            Assert.Equal(expected_Output, output);
        }

        /// <summary>
        /// Tests back parsing numbers to 64-base numeral system representations of
        /// radix base notation.
        /// </summary>
        [Theory]
        [InlineData(0e0, "1")]
        [InlineData(-1e0, "0,1")]
        [InlineData(-2e0, "0,01")]
        [InlineData(-3e0, "0,001")]
        [InlineData(-4e0, "0,0001")]
        public void Back_Parser_Force_Radix_Base_Comma_In_64NS(double number, string expected_Output)
        {
            // Arrange & Act

            number = (double)(Math.Pow(64e0, number));

            string output = Back_Parse_Radix_Base_Comma_Mock_Test(number, 64);

            // Assert

            Assert.Equal(expected_Output, output);
        }
    }
}