using System;
using Common_Library;

namespace Calculator_Annihilator.Mock_Tests
{
    /// <summary>
    /// Class that Mocks Back_Parser_Fascede class for unit tests.
    /// </summary>
    partial class Back_Parser_Mocked_Fascede : Back_Parser_Fascede
    {
        Number_Notation number_Notation;

        sbyte numeral_System_Type;

        string comma_Type;

        /// <summary>
        /// Mocks creation of Fascede for back parsing numbers for notations not using a comma sign. 
        /// </summary>
        public Back_Parser_Mocked_Fascede(Number_Notation _number_Notation,
            sbyte _numeral_System_Type) : this(_number_Notation, _numeral_System_Type, String.Empty)
        {
        }

        /// <summary>
        /// Mocks creation of Fascede for back parsing numbersr all notations. 
        /// </summary>
        public Back_Parser_Mocked_Fascede(Number_Notation _number_Notation,
            sbyte _numeral_System_Type, string _comma_Type) : base(null)
        {
            numeral_System_Type = _numeral_System_Type;

            number_Notation = _number_Notation;
            comma_Type = _comma_Type;
        }

        /// <summary>
        /// Returns given number to string representation of a number according to mocked settings.
        /// </summary>
        internal string Parse_Back(INumber Number)
        {
            return Parse_Back(Number, numeral_System_Type, number_Notation, comma_Type);
        }
    }
}

//using (AutoMock mock = AutoMock.GetLoose())
//{
//    mock.Mock<Equation>().Setup(x => x.the_Equation ).Returns("5+2");

//    var cls = mock.Create<Equation>();

//    var actual = cls.the_Equation;

//    mock.Mock<Equation>().Verify(x => x.Recreate_Equation(), Moq.Times.Exactly(1));

//    Xunit.Assert.Equal(actual, expected);
//}
