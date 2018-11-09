using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Calculator_Annihilator;

namespace Calculator_Annihilator.UTests
{
	/// <summary>
	/// Test proper reading of text with equation by Equation class and tests does repairs of incorrectnesses
	/// are done by class according to business logic via method Recreate_Equation(). 
	/// </summary>
	public class Equation_Tests
	{
		private Equation _equation;

		public Equation_Tests()
		{
			_equation = null;
		}

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

		/// <summary>
		/// Tests reading of text with equation with some mistakes made and check do they are repair according to business logic.
		/// </summary>
		[Theory] 

		[InlineData(")+2)*(7/4*3+7)", "(2)*(7/4*3+7)")] // wrong signs in the beging of equaton
		[InlineData("(7/4*3+7)*(/(+(-(*(-(*", "(7/4*3+7)")] // wrong signs at the end of equaton
		[InlineData("(5+2)(7/4*3+7)", "(5+2)*(7/4*3+7)")] // missing multiplication symbol between brackets
		[InlineData("2(7/4*3+7)", "2*(7/4*3+7)")] // missing multiplication symbol between bracket and number
		[InlineData("5+()2", "5+2")] // empty bracket
		[InlineData("5+()/2", "5+2")] // empty bracket and naother operand
		[InlineData("6-6--658", "-658")] // few operand in row

		[InlineData("(78+9)))", "(((78+9)))")] // test

		public void Recreate_Equation_Should_Integrity_Check_Works(string str, string expected)
		{
			_equation = new Equation(str, new Numeral_System(10));

			string actual = _equation.Recreate_Equation();

			Assert.Equal(expected, actual);
		}

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