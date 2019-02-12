using System;

namespace Calculator_Annihilator
{
	partial class MainWindow // Operation buttons actions
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
			if (Convert.ToBoolean(options.Calculation_Method == Calculation_Method.Single))
			{
				Equals_Single();
			}
			else if (Convert.ToBoolean(options.Calculation_Method == Calculation_Method.Complex))
			{
				Equals_Complex(WorkSpace.Text);
			}
		}
	}
}
