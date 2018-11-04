using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	class Complex_Equation_Ends_Up_With_Operator_Exception : Exception // xyz: check does used
	{
		double result;
		char sign;

		public Complex_Equation_Ends_Up_With_Operator_Exception()
		{

		}
		public Complex_Equation_Ends_Up_With_Operator_Exception(double r, char s) : base() // xyz check does is finnaly used
		{
			result = r;
			sign = s;
		}
		public Complex_Equation_Ends_Up_With_Operator_Exception(string message) : base(message)
		{

		}
		public Complex_Equation_Ends_Up_With_Operator_Exception(string message, Exception inner) : base(message, inner)
		{

		}
	}
}
