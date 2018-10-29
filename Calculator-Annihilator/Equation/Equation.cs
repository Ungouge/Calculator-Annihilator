using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator_Annihilator
{
	public partial class Equation
	{
		public string the_Equation;

		private Numerical_System _Numerical_System;

		private Parser _Parser = new Parser();
		private Calc _Calc = new Calc();

		private Equation_Elements Elements_Colection = new Equation_Elements();

		public double Solved_Value
		{
			get
			{
				if (Does_Solved == false)
					Solver();

				return Solved_Value;
			}
			private set
			{
				Solved_Value = value;
			}
		}
		private bool Does_Solved = false;

		public Equation ( string eq, Numerical_System ns )
		{
			try
			{
				the_Equation = eq;
				_Numerical_System = ns;

				Element_Selector(eq);
				Equation_Mapper();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public Equation()
		{
			 //the_Equation = "";
			 //numerical_System = new Numerical_System(10);
		}
	}
}
