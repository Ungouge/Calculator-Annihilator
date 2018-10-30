﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Calculator_Annihilator;

namespace Calculator_Annihilator
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

		[Theory]
		[InlineData("5,55615+2,1601)", "(5,55615+2,1601)")]
		[InlineData("(5+2)*((74934/4535*345+4357)/(34^(5,433)", "(5+2)*((74934/4535*345+4357)/(34^(5,433)))")]

		public void Recreate_Equation_Should_Restore_Missing_bracts(string str, string expected)
		{
			_equation = new Equation(str, new Numerical_System(10));

			string actual = _equation.Recreate_Equation();

			Assert.Equal(actual, expected);
		}

	}
}
