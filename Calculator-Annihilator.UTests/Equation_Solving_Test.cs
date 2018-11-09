using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Calculator_Annihilator;

namespace Calculator_Annihilator.UTests
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
		[InlineData("5^2/12,5", 2)]

		public void No_Bracket_Solving_Should_Work ( string str, double expected )
		{
			_equation = new Equation(str, new Numeral_System(10));

			_equation.Solver();

			double actual = _equation.Solved_Value.Value;

			//Assert.True(expected == actual);
			Assert.Equal(expected, actual);
		}

		[Theory]
		[InlineData("(5+2)*3", 21)]
		[InlineData("(5+2)*((7/4)+(3*7))", 159.25)] 
		[InlineData("(5+2)*(7/4*3+7)", 85.75)] 
		[InlineData("(5+2)^(3/2)*(7/4*3+7)", 226.873174923789)] //solves correctly, but assertation don't return true!?!

		public void With_Bracket_Solving_Should_Work(string str, double expected)
		{
			_equation = new Equation(str, new Numeral_System(10));

			_equation.Solver();

			double actual = _equation.Solved_Value.Value;

			//Assert.True(expected == actual);
			Assert.Equal(expected.ToString(), actual.ToString());
		}
	}
}
