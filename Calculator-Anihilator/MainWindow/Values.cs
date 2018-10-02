using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Anihilator
{
	public partial class MainWindow
	{
		private static readonly char[] action_Sings = { '+', '-', '*', '/' };
		private static readonly char[] commasType = { ',', '.', '٫' }; // if not in someverelse that PArser - to delete
		public sbyte Numeral_System; // value is base of numericalc system, while -3 is balanced ternary //Spagheti value

		Numerical_System_Signs Current_Numerical_System;
		private char[] numerical_System_Signs;

		private double first_Number_In_Equation_Single; //Psedonullable double container fo 
		private double First_Number_In_Equation_Single
		{
			get 
			{
				bool doGet = no_First_Number_In_Equation_Single;
				no_First_Number_In_Equation_Single = true;
				return doGet == false ? first_Number_In_Equation_Single : 0e0;
			}
			set
			{
				first_Number_In_Equation_Single = value;
				no_First_Number_In_Equation_Single = false;
			}
		}
		private bool no_First_Number_In_Equation_Single = true;

		/*public double probe_First_Number_In_Equation_Single() // return value of "first number" not using it
		{// will be neede I don't knnow
			double value = First_Number_In_Equation_Single;
			no_First_Number_In_Equation_Single = false;
			return value;
		}*/

		private char calculation_Sign_Single;
		private char Calculation_Sign_Single
		{
			get { return no_Calculation_Sign_Single == false ? calculation_Sign_Single : (char)0; }
			set
			{
				calculation_Sign_Single = value;
				no_Calculation_Sign_Single = false;
			}
		}
		private bool no_Calculation_Sign_Single = true;

	}
}
