using System;
using System.Windows;

namespace Calculator_Annihilator
{
	partial class MainWindow // Operation buttons sack
	{
        internal void Button_PlusSign_Action()
		{
			Operation_Button(new Addition());
		}

        internal void Button_MinuSing_Action()
		{
			Operation_Button(new Subtraction());
		}

        internal void Button_MultiplicationSing_Action()
        {
            Operation_Button(new Multiplication());
        }

        internal void Button_DivisionSign_Action()
		{
			Operation_Button(new Division());
		}

        internal void Button_Percent_Action()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Controls perfomance of equals button according to calculation options setup.
        /// </summary>
        internal void Button_Equals_Action()
		{
			if (Convert.ToBoolean(_Static_Resources.Calculation_Method == Calculation_Method.Single))
			{
				Equals_Single();
			}
			else if (Convert.ToBoolean(_Static_Resources.Calculation_Method == Calculation_Method.Complex))
			{
				Equals_Complex(WorkSpace.Text);
			}
		}

        internal void Button_ANS_Action()
        {
            throw new NotImplementedException();
        }

        internal void Button_CE_Action()
		{
            Clear_WorkSpace();
        }

        internal void Button_BackSpace_Action()
        {
            BackSpace_WorkSpace();
        }

        internal void Exponent_Button_Action()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Controls perfomance of clear button according to calculation options setup.
        /// </summary>
        internal void Button_Clear_Action()
		{
			Clear_WorkSpace();
			Clear_ResultSpace();

			if (Convert.ToBoolean(_Static_Resources.Calculation_Method == Calculation_Method.Single))
			{
				no_operand_Sign_Single = true;
				no_First_Number_In_Equation_Single = true;
			}
			else if (Convert.ToBoolean(_Static_Resources.Calculation_Method == Calculation_Method.Complex))
			{
				Equation = null;
			}

		}
	}
}
