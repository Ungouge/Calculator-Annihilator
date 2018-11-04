using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Calculator_Annihilator;

namespace Calculator_Annihilator.UTests
{
	public class Equation_Tests
	{
		private Equation _equation;

		public Equation_Tests()
		{
			_equation = null;
		}

		[Theory]
		[InlineData("5+2")]
		[InlineData("5*2")]
		[InlineData("5^2")]
		[InlineData("5+2*8")]
		[InlineData("(5,55615+2,1601)")]
		[InlineData("(5+2)*((74934/4535*345+4357)/(34^(5,433)))")]

		public void Recreate_Equation_Should_Work(string str)
		{
			_equation = new Equation(str, new Numerical_System(10));

			string actual = _equation.Recreate_Equation();

			Assert.Equal(actual, str);
		}

		[Theory] // Chceking integrity 
		[InlineData(")+2)*(7/4*3+7)", "(2)*(7/4*3+7)")] // wrong signs in the beging of equaton
		[InlineData("(5+2)(7/4*3+7)", "(5+2)*(7/4*3+7)")] // missing multiplication symbol between brackets
		[InlineData("2(7/4*3+7)", "2*(7/4*3+7)")] // missing multiplication symbol between bracket an number
		[InlineData("5+()2", "5+2")] // empty bracket
		[InlineData("5+()/2", "5+2")] // empty bracket and naother operand


		public void Recreate_Equation_Should_Integrity_Check_Works(string str, string expected)
		{
			_equation = new Equation(str, new Numerical_System(10));

			string actual = _equation.Recreate_Equation();

			Assert.Equal(expected, actual);
		}

		[Theory]
		[InlineData("5,55615+2,1601)", "(5,55615+2,1601)")]
		[InlineData("5+2)*((7/4)-(3*7)", "(5+2)*((7/4)-(3*7))")]
		[InlineData("(5+2)*((7/4*3+7)/(4^(5,3)", "(5+2)*((7/4*3+7)/(4^(5,3)))")]


		public void Recreate_Equation_Should_Restore_Missing_Bracts(string str, string expected)
		{
			_equation = new Equation(str, new Numerical_System(10));

			string actual = _equation.Recreate_Equation();

			Assert.Equal(expected, actual);
		}

	}
}
