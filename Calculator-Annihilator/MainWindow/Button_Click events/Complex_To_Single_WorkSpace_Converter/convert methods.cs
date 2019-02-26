using System;

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        partial class Complex_To_Single_WorkSpace_Converter
        {
            /// <summary>
            /// Switching calculator to single calculation mode while in workspace is complex equation.
            /// </summary>
            private void Complex_Equation_To_Solve_In_WorsSpace()
            {
                MainWindow.Reset_ResultSpace_Text(ToString());

                MainWindow.no_First_Number_In_Equation_Single = false;
                MainWindow.First_Number_In_Equation_Single = Solved_Number;

                MainWindow.no_operand_Sign_Single = true;

                MainWindow.Clear_WorkSpace();
            }

            /// <summary>
            /// Switching calculator to single calculation mode while in workspace is whole single equation.
            /// </summary>
            private void Whole_Single_Equation_In_WorkSpace(INumber First_Number, IOperand Operand, INumber Seccond_Number)
            {
                MainWindow.no_First_Number_In_Equation_Single = false;
                MainWindow.First_Number_In_Equation_Single = First_Number;

                MainWindow.Reset_ResultSpace_Text(MainWindow.Back_Parser.Parse_Back(MainWindow.First_Number_In_Equation_Single));

                MainWindow.no_operand_Sign_Single = false;
                MainWindow.operand_Sign_Single = Operand;

                MainWindow.Insert_To_ResultSpace(MainWindow.operand_Sign_Single.ToString());

                MainWindow.Reset_WorkSpace_Text(MainWindow.Back_Parser.Parse_Back(Seccond_Number));
            }

            /// <summary>
            /// Switching calculator to single calculation mode while in workspace is number and an operator.
            /// </summary>
            private void Number_And_operand_In_WorkSpace_To_Single(INumber First_Number, IOperand Operand)
            {
                MainWindow.no_First_Number_In_Equation_Single = false;
                MainWindow.First_Number_In_Equation_Single = First_Number;

                MainWindow.Reset_ResultSpace_Text(MainWindow.Back_Parser.Parse_Back(MainWindow.First_Number_In_Equation_Single));

                MainWindow.no_operand_Sign_Single = true;
                MainWindow.operand_Sign_Single = Operand;

                MainWindow.Insert_To_ResultSpace(MainWindow.operand_Sign_Single.ToString());

                MainWindow.Clear_WorkSpace();
            }

            /// <summary>
            /// Switching calculator to single calculation mode while in workspace is only one number.
            /// </summary>
            private void Only_Number_In_WorkSPace_To_single(INumber First_Number)
            {
                MainWindow.First_Number_In_Equation_Single = First_Number;
                MainWindow.no_First_Number_In_Equation_Single = false;

                MainWindow.Reset_ResultSpace_Text(MainWindow.Back_Parser.Parse_Back(MainWindow.First_Number_In_Equation_Single));

                MainWindow.Clear_WorkSpace();
            }

            /// <summary>
            /// Switching calculator to single calculation mode while workspace is empty.
            /// </summary>
            private void Empty_WorkSpace_ToSingle()
            {
                MainWindow.Clear_ResultSpace();
                MainWindow.Clear_WorkSpace();

                MainWindow.no_operand_Sign_Single = true;
                MainWindow.no_First_Number_In_Equation_Single = true;
            }
        }
    }
}
