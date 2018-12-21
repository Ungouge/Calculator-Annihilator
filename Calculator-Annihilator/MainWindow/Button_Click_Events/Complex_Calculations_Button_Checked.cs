
using System.Windows;

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
				newWorkSpaceText += First_Number_In_Equation_Single.ToString();

			if (no_operand_Sign_Single == false)
				newWorkSpaceText += Operand_Sign_Single.ToString();

			newWorkSpaceText += WorkSpace.Text;

			Reset_WorkSpace_Text(newWorkSpaceText);

			no_operand_Sign_Single = true;
			no_First_Number_In_Equation_Single = true;
        
			Enable_Complex_Buttons();
		}

		/// <summary>
		/// Enables buttons that have use in complex calculations.
		/// </summary>
		private void Enable_Complex_Buttons()
		{
			//Button_Open_Bracket.IsEnabled = true;
			//Button_Close_Bracket.IsEnabled = true;
		}
	}
}
