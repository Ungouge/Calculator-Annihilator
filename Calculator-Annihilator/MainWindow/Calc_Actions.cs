using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	public partial class MainWindow
	{
		private void Action_Button(char sign)
		{
			if (Convert.ToBoolean(Single_Calculations.IsChecked == true))
				Basic_Calculation_Single(sign);
			else if (Convert.ToBoolean(Complex_Calculations.IsChecked == true))
				Insert_To_WorkSpace(sign);
		}

		private void Basic_Calculation_Single(char symbol)
		{
			if (no_operand_Sign_Single == true)
			{
				First_Number_In_Equation_Single = Parse_WorkSpace();
				Reset_ResultSpace_Text(first_Number_In_Equation_Single.ToString() + symbol);
			}
			else if (WorkSpace.Text != default(string) || WorkSpace.Text != "")
			{
				try
				{
					first_Number_In_Equation_Single = 
						calc.Operand_Selector(Operand_Sign_Single, first_Number_In_Equation_Single, Parse_WorkSpace());
					Reset_ResultSpace_Text(first_Number_In_Equation_Single.ToString());
				}
				catch (DivideByZeroException)
				{
					Reset_ResultSpace_Text("Dividing by zero is not allowed");
					no_operand_Sign_Single = true;
					no_First_Number_In_Equation_Single = true;
				}
				catch
				{
					Reset_ResultSpace_Text(default(string));
					symbol = default(char);
				}
				finally
				{
					Clear_WorkSpace();
				}
			}

			Operand_Sign_Single = symbol;
			Clear_WorkSpace();
		}
	}
}
