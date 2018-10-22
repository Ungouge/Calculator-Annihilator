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

namespace Calculator_Anihilator
{
	public partial class MainWindow
	{
		public static readonly char[][] action_Sings = new char[][]
		{ 
			new char [] { '^' },
			new char [] { '-', '+' },
			new char [] { '/', '*' }
		};

		public static readonly char[] CommasType = { ',', '.', '٫' }; // if not in someverelse that Parser - to delete
		public static sbyte Numeral_System { get; private set; } // value is base of numericalc system, while -3 is balanced ternary //Spagheti value

		Numerical_System_Signs Current_Numerical_System;
		public static char[] Numerical_System_Signs { get; private set; }

		private double first_Number_In_Equation_Single; //Psedonullable double container for single
		private double First_Number_In_Equation_Single
		{
			get
			{
				bool doGet = no_First_Number_In_Equation_Single;
				no_First_Number_In_Equation_Single = true;
				return !doGet ? first_Number_In_Equation_Single : 0e0;
			}
			set
			{
				first_Number_In_Equation_Single = value;
				no_First_Number_In_Equation_Single = false;
			}
		}
		private bool no_First_Number_In_Equation_Single = true;

		private char calculation_Sign_Single;
		private char Calculation_Sign_Single
		{
			get { return no_Calculation_Sign_Single == false ? calculation_Sign_Single : Convert.ToChar(0); ; }
			set
			{
				calculation_Sign_Single = value;
				no_Calculation_Sign_Single = false;
			}
		}
		private bool no_Calculation_Sign_Single = true;

	}
}
