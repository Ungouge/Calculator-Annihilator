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
		public void Addition_SouldCaculate(double x, double y, double expected)
		{
			// Act
			double actual = Calc.Operand_Selector('+', x, y);

			// Assert
			Assert.Equal(expected, actual);
		}
	}
}
