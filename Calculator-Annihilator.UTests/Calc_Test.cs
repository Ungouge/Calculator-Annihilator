using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator_Annihilator;
using Xunit;

namespace Calculator_Annihilator.UTests
{
	public class Calc_Test
	{
		[Theory]
		[InlineData(2, 3, 5)]
		[InlineData(5e-1, 3e0, 35e-1)]
		[InlineData(0.11111, 0.22222, 0.33333)]
		[InlineData(Double.MaxValue, 116515e15, Double.MaxValue)]
		public void Addition_ShouldCaculate(double x, double y, double expected)
		{
			// Act
			double actual = Calc.Operand_Selector('+', x, y);

			// Assert
			Assert.Equal(expected, actual);
		}
	}
}
