using System;
using Xunit;
using Assert = Xunit.Assert;

namespace Calculator_Annihilator.Mock_Tests
{
    public class Back_Parse_Scienfic_Normalized_Mock_Tests
    {
        /// <summary>
        /// Returns given number in given numeral system as string representation in
        /// normalised scientific notation.
        /// </summary>
        public string Back_Parse_Scienfic_Normalized_Mock_Test(double number, sbyte numeral_System_Type)
        {
            Back_Parser_Mocked_Fascede Back_Parser = new Back_Parser_Mocked_Fascede(Number_Notation.Scienfic_Normalized, numeral_System_Type, ",");

            // Act

            INumber Number = new Number(number);

            return Back_Parser.Parse_Back(Number);
        }

        /// <summary>
        /// Tests back parsing numbers to decimal representations in SCientific normalized notation.
        /// </summary>
        [Theory]
        [InlineData(11e-1, "1,1*10\x2070")]
        [InlineData(9E-11, "9*10\x207B\xB9\xB9")]
        [InlineData(1e1, "1*10\xB9")]
        [InlineData(1e-1, "1*10\x207B\xB9")]
        [InlineData(987654321e20, "9,87654321*10\xB2\x2078")]
        [InlineData(987654321e-5, "9,87654321*10\xB3")]
        [InlineData(-987654321e-5, "-9,87654321*10\xB3")]
        [InlineData(123456789e-41, "1,23456789*10\x207B\xB3\xB3")]
        public void Back_Parse_Decimal(double number, string expected_Output)
        {
            // Arrange & Act

            string output = Back_Parse_Scienfic_Normalized_Mock_Test(number, 10);

            // Assert

            Assert.Equal(expected_Output, output);
        }
    }
}