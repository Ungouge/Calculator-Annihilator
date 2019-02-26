using System;
using Common_Library;

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

            if (Convert.ToBoolean(Options.Calculation_Method == Calculation_Method.Single))
            {
                no_operand_Sign_Single = true;
                no_First_Number_In_Equation_Single = true;
            }
            else // if (Convert.ToBoolean(_Static_Resources.Calculation_Method == Calculation_Method.Complex))
            {
                Equation = null;
            }
        }

        internal void Button_Change_Sign_Action()
        {
            if (WorkSpace.Text[0] == '-')
                Remove_From_WorkSpace(0, 1);
            else
                Insert_To_WorkSpace(0, '-');
        }

        internal void Button_Invert_Number_Action()
        {
            Number WorkSpace_Number = Parse_WorkSpace();

            if (WorkSpace_Number.Value != 0)
                WorkSpace_Number = _Calculator.Operand_Selector(new Division(), new Number(1), WorkSpace_Number);

            Reset_WorkSpace_Text(Back_Parser.Parse_Back(WorkSpace_Number));
        }
    }
}
