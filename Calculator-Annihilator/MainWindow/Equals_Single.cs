using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	partial class MainWindow //Equals_Single
	{
		/// <summary>
		/// Controlls action after pressing equals button when option for single calculations is on.
		/// </summary>
		private void Equals_Single( )
		{
			try
			{
				Number calculation_Result = calc.Operand_Selector(Operand_Sign_Single, first_Number_In_Equation_Single, Parse_WorkSpace());
				Reset_ResultSpace_Text(calculation_Result.ToString());
			}
			catch (DivideByZeroException)
			{
				Reset_ResultSpace_Text("Dividing by zero is not allowed");
			}
			catch
			{
				Reset_ResultSpace_Text(default(string));
			}
			finally
			{
				no_operand_Sign_Single = true;
				no_First_Number_In_Equation_Single = true;
				Clear_WorkSpace();
			}
		}
	}
}
