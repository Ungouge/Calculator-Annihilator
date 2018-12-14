using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	public partial class MainWindow //Operation_Actions
	{
		/// <summary>
		/// Controls perfomance of action buttons according to calculation options setup.
		/// </summary>
		/// <param name="_Operand"></param>
		private void Operation_Button(IOperand _Operand)
		{
			if (Convert.ToBoolean(GUI_Dynamic_Parameters.Calculation_Method == Calculation_Method.Single))
				Basic_Calculation_Single(_Operand);
			else if (Convert.ToBoolean(GUI_Dynamic_Parameters.Calculation_Method == Calculation_Method.Complex))
				Insert_To_WorkSpace(_Operand.ToString());
		}

		/// <summary>
		/// Controls proper perfoming of operation button according to whether some operation were perfomed ealier.
		/// </summary>
		/// <param name="symbol"></param>
		private void Basic_Calculation_Single(IOperand symbol)
		{
			if (no_operand_Sign_Single == true)
			{
				First_Number_In_Equation_Single = Parse_WorkSpace();
				Reset_ResultSpace_Text(first_Number_In_Equation_Single.ToString() + symbol.ToString());
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
					symbol = default(IOperand);
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
