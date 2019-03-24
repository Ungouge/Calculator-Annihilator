using System;
using Common_Library;

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
			if (Convert.ToBoolean(Options.Calculation_Method == Calculation_Method.Single))
				Basic_Calculation_Single(_Operand);
			else if (Convert.ToBoolean(Options.Calculation_Method == Calculation_Method.Complex))
				Insert_To_WorkSpace(_Operand.ToString());
		}

		/// <summary>
		/// Controls proper perfoming of operation button according to whether some operation were perfomed ealier.
		/// </summary>
		private void Basic_Calculation_Single(IOperand symbol)
		{
            // To rebuild after rebuilding exceptions thrown by Parser.

            string new_ResultSpace_Text;

			if (no_operand_Sign_Single == true)
			{
                if(no_First_Number_In_Equation_Single == true)
                {
			        First_Number_In_Equation_Single = Parse_WorkSpace();

                    new_ResultSpace_Text =
                        Back_Parser.Parse_Back(first_Number_In_Equation_Single) + symbol.ToString();
                }
                else
                {
                    new_ResultSpace_Text = 
                        Back_Parser.Parse_Back(first_Number_In_Equation_Single) + symbol.ToString();
                }
			}
			else if ( (String.IsNullOrEmpty(WorkSpace.Text)
                || String.IsNullOrWhiteSpace(WorkSpace.Text)) == true )
            {
				try
				{
					first_Number_In_Equation_Single = 
						_Calculator.Operand_Selector(Operand_Sign_Single, first_Number_In_Equation_Single, Parse_WorkSpace());

                    new_ResultSpace_Text = 
                        Back_Parser.Parse_Back(first_Number_In_Equation_Single);
				}
				catch (DivideByZeroException)
				{
                    new_ResultSpace_Text = "Dividing by zero is not allowed";

					no_operand_Sign_Single = true;

					no_First_Number_In_Equation_Single = true;
				}
				catch
				{
                    new_ResultSpace_Text = ResultSpace.Text;

					symbol = Operand_Sign_Single;
				}
			}
            else
            {
                new_ResultSpace_Text = ResultSpace.Text;
            }

            Reset_ResultSpace_Text(new_ResultSpace_Text);

            Operand_Sign_Single = symbol;

			Clear_WorkSpace();
		}
	}
}
