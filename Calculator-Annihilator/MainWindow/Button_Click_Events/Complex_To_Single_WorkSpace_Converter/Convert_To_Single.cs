using System;

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        partial class Complex_To_Single_WorkSpace_Converter
        {
            /// <summary>
            /// Checks is current complex calculation data may be converted to complex calculation while switching methods.
            /// </summary>
            internal void Convert_To_Single()
            {
                if (Element_Colection.Count > 3)
                {
                    Complex_Equation_To_Solve_In_WorsSpace();
                    return;
                }
                else if (Element_Colection.Count == 0)
                {
                    Empty_WorkSpace_ToSingle();
                    return;
                }

                else
                {
                    if (Element_Colection[0] is INumber First_Number)
                    {
                        if (Element_Colection.Count > 1)
                        {
                            if (Element_Colection[1] is IOperand Operand)
                            {
                                if (Element_Colection.Count == 3)
                                {
                                    if (Element_Colection[2] is INumber Seccond_Number)
                                    {
                                        Whole_Single_Equation_In_WorkSpace(First_Number, Operand, Seccond_Number);

                                        return;
                                    }
                                    else
                                        Number_And_operand_In_WorkSpace_To_Single(First_Number, Operand);

                                    return;
                                }
                                else
                                    Number_And_operand_In_WorkSpace_To_Single(First_Number, Operand);

                                return;
                            }
                            else
                                Only_Number_In_WorkSPace_To_single(First_Number);

                            return;
                        }
                        else
                            Only_Number_In_WorkSPace_To_single(First_Number);

                        return;
                    }
                    else
                        Empty_WorkSpace_ToSingle();
                    return;
                }
            }
        }
    }
}
