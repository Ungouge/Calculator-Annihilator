using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Calculator_Annihilator;
using DemoLibrary;

namespace Calculator_Annihilator.Test
{
	public class Calc_test
	{
		[thoery]
		public void Addition_Calc_Test()
		{
			// arrange
			double expected = 5;
			// Act
			double actual = MainWindow.Calc_Action_Selector('+', 2e0, 3e0);
			// Assert
		}
	}
}
