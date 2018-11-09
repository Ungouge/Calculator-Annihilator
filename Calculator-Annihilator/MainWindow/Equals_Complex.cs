using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator_Annihilator
{
	partial class MainWindow //Equals_Complex
	{
		/// <summary>
		/// Controlls action after pressing equals button when option for complex calculations is on.
		/// </summary>
		private double Equals_Complex(string equation)
		{
			Current_Complex_Equation = new Equation(equation, Current_Numerical_System);
			Current_Complex_Equation.Solver();
			return Current_Complex_Equation.Solved_Value.Value;
		}
	}
}
