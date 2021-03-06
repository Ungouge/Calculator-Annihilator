﻿using System;
using Common_Library;
using Xunit;
using Assert = Xunit.Assert;

namespace Calculator_Annihilator_Library.Tests
{
    public class Engineering_Notation_Back_Parse_Tests
    {
        private Back_Parser_Fascede Back_Parser;

        /// <summary>
        /// Returns given number in given numeral system as string representation in engineering notation.
        /// </summary>
        public string Back_Parse_Engineering_Mock_Test(double number, sbyte numeral_System_Type)
        {
            Back_Parser = new Back_Parser_Fascede(Number_Notation.Engineering, numeral_System_Type, ",");

            // Act

            INumber Number = new Number(number);

            return Back_Parser.Parse_Back(Number);
        }

        /// <summary>
        /// Tests back parsing numbers to decimal representations of engineering notation.
        /// </summary>
        [Theory]
        [InlineData(11e-1, "1,1*10\x2070")]
        [InlineData(9E-11, "90*10\x207B\xB9\xB2")]
        [InlineData(1e0, "1*10\x2070")]
        [InlineData(1e-1, "100*10\x207B\xB3")]
        [InlineData(1234e5, "123,4*10\x2076")]
        [InlineData(987654321e20, "98,7654321*10\xB2\x2077")]
        [InlineData(987654321e-5, "9,87654321*10\xB3")]
        [InlineData(-987654321e-5, "-9,87654321*10\xB3")]
        [InlineData(123456789e-41, "1,23456789*10\x207B\xB3\xB3")]
        public void Back_Parse_Decimal(double number, string expected_Output)
        {
            // Arrange & Act

            string output = Back_Parse_Engineering_Mock_Test(number, 10);

            // Assert

            Assert.Equal(expected_Output, output);
        }
    }
}
