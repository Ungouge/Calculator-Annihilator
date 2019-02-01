using System.Windows;
using System.Windows.Controls;

namespace Calculator_Annihilator
{
	partial class MainWindow
	{
		/// <summary>
		/// Switches calculator to complex calculation mode.
		/// </summary>
		private void Complex_Calculations_Button_Checked(object sender, RoutedEventArgs e)
		{
            _Static_Resources.Calculation_Method = Calculation_Method.Complex;

			string newWorkSpaceText = "";

			if (no_First_Number_In_Equation_Single == false)
				newWorkSpaceText += Back_Parser.Parse_Back(First_Number_In_Equation_Single);

			if (no_operand_Sign_Single == false)
				newWorkSpaceText += Operand_Sign_Single.ToString();

			newWorkSpaceText += WorkSpace.Text;

			Reset_WorkSpace_Text(newWorkSpaceText);

			no_operand_Sign_Single = true;
			no_First_Number_In_Equation_Single = true;

            Set_Specialized_Buttons();
		}
	}
}
