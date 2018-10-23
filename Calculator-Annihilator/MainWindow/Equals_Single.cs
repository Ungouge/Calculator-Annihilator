using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	public partial class MainWindow
	{

		private void Equals_Single( )
		{
			try
			{
				double calculation_Result = Calc_Action_Selector(Calculation_Sign_Single, first_Number_In_Equation_Single, Parse_WorkSpace());
				no_Calculation_Sign_Single = true;
				no_First_Number_In_Equation_Single = true;
				ResultSpace.Text = calculation_Result.ToString();
			}
			catch (DivideByZeroException)
			{
				ResultSpace.Clear();
				ResultSpace.Text = "Dividing by zero is not allowed";
			}
			finally
			{
				Clear_WorkSpace();
			}
		}
	}
}
