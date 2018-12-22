using System;

namespace Calculator_Annihilator
{
    partial class MainWindow //additional buttons action
    {

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

        internal void Button_Change_Sign_Action() //xyz To Implement
        {
            throw new NotImplementedException();
        }

        internal void Button_Invert_Number_Action()//xyz To Implement
        {
            throw new NotImplementedException();
        }
    }
}
