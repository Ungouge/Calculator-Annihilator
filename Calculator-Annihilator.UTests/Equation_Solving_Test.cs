using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Calculator_Annihilator;

namespace Calculator_Annihilator
{
	public class Equation_Solving_Test
	{
		private Equation _equation;

		public Equation_Solving_Test()
		{
			_equation = null;
		}

		[Theory]
		[InlineData("5+2", 7)]
		[InlineData("5+2*8", 21)]
		[InlineData("5^2*12,5/", 2)]

		public void No_Bracket_Solving_Should_Work ( string str, double expected )
		{
			_equation = new Equation(str, new Numerical_System(10));

			double actual = _equation.Solved_Value;

			Assert.Equal(actual, expected);

		}
	}
}
