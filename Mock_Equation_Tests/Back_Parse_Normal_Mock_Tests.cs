using System;
using Xunit;
using Assert = Xunit.Assert;

namespace Calculator_Annihilator.Mock_Tests
{
    public class Back_Parse_Normal_Mock_Tests
    {
        /// <summary>
        /// Returns given number in given numeral system as string representation in
        /// normal notation.
        /// </summary>
        public string Back_Parse_Normal_Mock_Test(double number, sbyte numeral_System_Type)
        {
            Back_Parser_Mocked_Fascede Back_Parser = new Back_Parser_Mocked_Fascede(Number_Notation.Normal, numeral_System_Type, ",");

            // Act

            INumber Number = new Number(number);

            return Back_Parser.Parse_Back(Number);
        }

        /// <summary>
        /// Tests back parsing numbers to quaternary representations in normal notation.
        /// </summary>
        [Theory]
        [InlineData(1048576, "10000000000")]
        [InlineData(1152921504606846976, "1E₄132")]
        [InlineData(288230376151711744, "100000000000000000000000000000")]
        [InlineData(244140625E-12, "0,000001")]
        [InlineData(1625E-2, "100,1")]
        [InlineData(64e0, "1000")]
        public void Back_Parse_Quaternary(double number, string expected_Output)
        {
            // Arrange & Act

            string output = Back_Parse_Normal_Mock_Test(number, 4);

            // Assert

            Assert.Equal(expected_Output, output);
        }

        /// <summary>
        /// Tests back parsing numbers to decimal representations in normal notation.
        /// </summary>
        [Theory]
        [InlineData(11e-1, "1,1")]
        [InlineData(9E-11, "0,00000000009")]
        [InlineData(1e1, "10")]
        [InlineData(1e-1, "0,1")]
        [InlineData(1e0, "1")]
        [InlineData(123456789e-2, "1234567,89")]
        public void Back_Parse_Decimal(double number, string expected_Output)
        {
            // Arrange & Act

            string output = Back_Parse_Normal_Mock_Test(number, 10);

            // Assert

            Assert.Equal(expected_Output, output);
        }

        /// <summary>
        /// Tests back parsing numbers to unary representations in normal notation.
        /// </summary>
        [Theory]
        [InlineData(0, "")]
        [InlineData(1, "1")]
        [InlineData(2, "11")]
        [InlineData(1e1, "1111111111")]
        [InlineData(5e-100, "1")]
        public void Back_Parser_Normal_Unary(double number, string expected_Output)
        {
            // Arrange & Act

            string output = Back_Parse_Normal_Mock_Test(number, 1);

            // Assert

            Assert.Equal(expected_Output, output);
        }

        /// <summary>
        /// Tests back parsing numbers to binary representations in normal notation.
        /// </summary>
        [Theory]
        [InlineData(2e0, "10")]
        [InlineData(16e0, "10000")]
        [InlineData(17e0, "10001")]
        [InlineData(25e-2, "0,01")]
        [InlineData(1e2, "1100100")]
        [InlineData(4e0, "100")]
        [InlineData(8e0, "1000")]
        [InlineData(6e0, "110")]
        [InlineData(9e0, "1001")]
        [InlineData(1e1, "1010")]
        public void Back_Parser_Normal_Binary(double number, string expected_Output)
        {
            // Arrange & Act

            string output = Back_Parse_Normal_Mock_Test(number, 2);

            // Assert

            Assert.Equal(expected_Output, output);
        }
    }
}
