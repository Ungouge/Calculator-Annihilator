using System;
using Common_Library;
using Xunit;
using Assert = Xunit.Assert;

namespace Calculator_Annihilator_Library.Tests
{
    public class Force_Exponent_Notaton_Back_Parse_Tests
    {
        private Back_Parser_Fascede Back_Parser;

        /// <summary>
        /// Returns given number in given numeral system as string representation in
        /// exponent notation.
        /// </summary>
        public string Back_Parse_Force_Exponent_Mock_Test(double number, sbyte numeral_System_Type)
        {
            Back_Parser = new Back_Parser_Fascede(Number_Notation.Force_Exponent, numeral_System_Type, ",");

            // Act

            INumber Number = new Number(number);

            return Back_Parser.Parse_Back(Number);
        }

        /// <summary>
        /// Tests back parsing numbers to decimal representations of exponent notation.
        /// </summary>
        [Theory]
        [InlineData(11e-1, "1,1E0")]
        [InlineData(9E-11, "9E-11")]
        [InlineData(1e1, "1E1")]
        [InlineData(1e-1, "1E-1")]
        [InlineData(1e0 / 3e0, "3,3333333333334E-1")]
        [InlineData(987654321e20, "9,87654321E28")]
        [InlineData(987654321e-5, "9,87654321E3")]
        [InlineData(-987654321e-3, "-9,87654321E5")]
        [InlineData(123456789e-41, "1,23456789E-33")]
        public void Back_Parse_Decimal(double number, string expected_Output)
        {
            // Arrange & Act

            string output = Back_Parse_Force_Exponent_Mock_Test(number, 10);

            // Assert

            Assert.Equal(expected_Output, output);
        }


        /// <summary>
        /// Tests back parsing numbers to ternary representations of exponent notation.
        /// </summary>
        [Theory]
        [InlineData(1e0, "1E\x20830")]
        [InlineData(2e0, "2E\x20830")]
        [InlineData(3e0, "1E\x20831")]
        [InlineData(4e0, "1,1E\x20831")]
        [InlineData(5e0, "1,2E\x20831")]
        [InlineData(6e0, "2E\x20831")]
        [InlineData(81e0, "1E\x208311")]
        [InlineData(1e2, "1,0201E\x208311")]
        [InlineData(108e0, "1,1E\x208311")]
        [InlineData(117e0, "1,11E\x208311")]
        [InlineData(120e0, "1,111E\x208311")]
        [InlineData(121e0, "1,1111E\x208311")]
        [InlineData(121e0 + (1e0 / 3e0), "1,11111E\x208311")]
        [InlineData(15e-1, "1,11111111111111111111111111111E\x20830")]
        [InlineData(5e-1, "1,11111111111111111111111111111E\x2083-1")]
        [InlineData(25e-2, "2,02020202020202020202020202021E\x2083-2")]
        [InlineData(125e-3, "1,0101010101010101010101010101E\x2083-2")]
        [InlineData(625e-4, "1,20012001200120012001200120012E\x2083-10")]
        [InlineData(3125e-5, "2,1121000211210002112100021121E\x2083-11")]
        [InlineData(15625e-6, "1,0210111220220001021011122022E\x2083-11")]
        [InlineData(1e0 / 3e0, "1E\x2083-1")]
        [InlineData(1e0 / 9e0, "1E\x2083-2")]
        [InlineData(1e0 / 27e0, "1E\x2083-10")]
        [InlineData((1e0 / 81e0) + (1e0 / 27e0), "1,1E\x2083-10")]
        [InlineData(1e68 - 1 + (1e0 / 27e0), "1,2022122012111110210211200111E\x208312021")]
        public void Back_Parser_Normal_Ternary(double number, string expected_Output)
        {
            // Arrange & Act

            string output = Back_Parse_Force_Exponent_Mock_Test(number, 3);

            // Assert

            Assert.Equal(expected_Output, output);
        }


        /// <summary>
        /// Tests back parsing numbers to quinary representations of exponent notation.
        /// </summary>
        [Theory]
        [InlineData(1e0, "1E\x20850")]
        [InlineData(2e0, "2E\x20850")]
        [InlineData(3e0, "3E\x20850")]
        [InlineData(4e0, "4E\x20850")]
        [InlineData(5e0, "1E\x20851")]
        [InlineData(5e0 * 5e0 * 5e0 * 5e0 * 5e0 * 5e0, "1E\x208511")]
        [InlineData(2e-1, "1E\x2085-1")]
        [InlineData(1e0 / 125e0 + 1e0 / 25e0 + 1e0 / 5e0, "1,11E\x2085-1")]
        public void Back_Parser_Normal_Quinary(double number, string expected_Output)
        {
            // Arrange & Act

            string output = Back_Parse_Force_Exponent_Mock_Test(number, 5);

            // Assert

            Assert.Equal(expected_Output, output);
        }


        /// <summary>
        /// Tests back parsing numbers to binary representations of exponent notation.
        /// </summary>
        [Theory]
        [InlineData(2e0, "1E₂1")]
        [InlineData(16e0, "1E₂100")]
        [InlineData(25e-2, "1E₂-10")]
        [InlineData(1e2, "1,1001E₂110")]
        public void Back_Parser_Normal_Binary(double number, string expected_Output)
        {
            // Arrange & Act

            string output = Back_Parse_Force_Exponent_Mock_Test(number, 2);

            // Assert

            Assert.Equal(expected_Output, output);
        }
    }
}