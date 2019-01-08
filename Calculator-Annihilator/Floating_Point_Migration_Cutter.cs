using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
    class Floating_Point_Migration_Cutter
    {
        MainWindow MainWindow;

        public Floating_Point_Migration_Cutter()
        {
            MainWindow = (MainWindow) System.Windows.Application.Current.MainWindow;
        }

        internal INumber Cut(INumber Number)
        {
            string result_In_Current_Numeral_System = "";// (Number as IOperand_ToString)/*.atCurrentNumeralSystem*/.ToStirng();

            if (result_In_Current_Numeral_System[result_In_Current_Numeral_System.Length - 2] == '0' &&
                result_In_Current_Numeral_System[result_In_Current_Numeral_System.Length - 3] == '0')
            {
                Parser Parser = new Parser();
                INumber Floating_Point_Migrant = Parser.Parse(
                    result_In_Current_Numeral_System[result_In_Current_Numeral_System.Length - 1].ToString(),
                    MainWindow.Get_Numeral_System);

                Calc Calc = new Calc();

                return Calc.Operand_Selector(new Subtraction(), Number, Floating_Point_Migrant);
            }

            return Number;

        }
    }
}
