using System;
using Calculator_Annihilator_Library;

namespace Calculator_Annihilator
{
	partial class MainWindow //Equals_Single
	{
		/// <summary>
		/// Controlls action after pressing equals button when option for single calculations is on.
		/// </summary>
		private void Equals_Single( )
        {
            string new_ResultSpace_Text;

            try
            {
                Number calculation_Result;

                if (no_First_Number_In_Equation_Single == true)
                {


                    return;
                }

                calculation_Result = _Calculator.Operand_Selector(Operand_Sign_Single, first_Number_In_Equation_Single, Parse_WorkSpace());

                new_ResultSpace_Text = Back_Parser.Parse_Back(calculation_Result);
                
                First_Number_In_Equation_Single = calculation_Result;
            }
			catch (DivideByZeroException)
			{
                new_ResultSpace_Text = "Dividing by zero is not allowed";
            }
			catch(Exception)
			{
                new_ResultSpace_Text = "Unknown error occur";
			}
			finally
			{
                no_operand_Sign_Single = true;
				//no_First_Number_In_Equation_Single = true;
				Clear_WorkSpace();
			}

            Reset_ResultSpace_Text(new_ResultSpace_Text);
		}
	}
}
