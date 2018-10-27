/*
 * using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Autofac.Extras.Moq;
using Xunit;
using Calculator_Annihilator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mock_Equation_Tests
{
	public class UnitTest1
	{
		[Theory]
		[InlineData("5+2")]
		public void MockingTest(string expected)
		{
			using (AutoMock mock = AutoMock.GetLoose())
			{
				mock.Mock<Equation>().Setup(x => x.the_Equation ).Returns("5+2");

				var cls = mock.Create<Equation>();

				var actual = cls.the_Equation;

				mock.Mock<Equation>().Verify(x => x.Recreate_Equation(), Moq.Times.Exactly(1));

				Xunit.Assert.Equal(actual, expected);
			}
		}
	}
}
*/