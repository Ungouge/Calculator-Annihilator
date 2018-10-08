using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Anihilator
{
	public partial class MainWindow
	{
		private void Action_Button(char sign)
		{
			if (Convert.ToBoolean(Single_Calculations.IsChecked == true))
				try
				{
					Basic_Calculation_Single(sign);
				}
				catch (Exception)
				{

				}
			else if (Convert.ToBoolean(Complex_Calculations.IsChecked == true))
				Insert_To_WorkSpace(sign.ToString());
		}

		private void Basic_Calculation_Single(char symbol)
		{
			if (no_Calculation_Sign_Single == true)
			{
				First_Number_In_Equation_Single = Parse_WorkSpace();
				ResultSpace.Text = first_Number_In_Equation_Single.ToString(); // experimental code
			}
			else
			{
				first_Number_In_Equation_Single = Calc_Action_Selector(Calculation_Sign_Single, first_Number_In_Equation_Single, Parse_WorkSpace());
				ResultSpace.Text = first_Number_In_Equation_Single.ToString();
			}
			Calculation_Sign_Single = symbol;
			Clear_WorkSpace();
		}
	}
}
