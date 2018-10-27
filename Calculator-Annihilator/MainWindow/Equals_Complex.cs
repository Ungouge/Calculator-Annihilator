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
	public partial class MainWindow
	{
		private double Equals_Complex(string equation)
		{
			Equation Eq = new Equation(equation, Current_Numerical_System);
			return Eq.Result; //Equals_No_Brackets(equation);
		}
	}
}
