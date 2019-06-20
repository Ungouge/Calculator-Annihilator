using System;
using Calculator_Annihilator_Library;
using Options_Library;
using Common_Library;

namespace Calculator_Annihilator
{
	partial class MainWindow
	{
        internal IOptions Options;

        protected override IOptions_Provider Options_Provider
        {
            get
            {
                return Options;
            }
        }

        private Calculator _Calculator = new Calculator();

        private Equation Equation;

        internal IBindable_Resources GUI_Bindable_Resources;

        private Parser Parser
        {
            get
            {
                return Options.Parser;
            }
        }

        private Back_Parser_Fascede Back_Parser
        {
            get
            {
                return Options.Back_Parser;
            }
        }

        protected internal Numeral_System Current_Numeral_System
        {
            get
            {
                return Options.Current_Numeral_System;
            }
        }

        private INumber first_Number_In_Equation_Single; //Psedonullable double container for single
		private INumber First_Number_In_Equation_Single
		{
			get
			{
				bool doGet = no_First_Number_In_Equation_Single;
				no_First_Number_In_Equation_Single = true;
				return !doGet ? first_Number_In_Equation_Single : default(INumber);
			}
			set
			{
				first_Number_In_Equation_Single = value;
				no_First_Number_In_Equation_Single = false;
			}
		}
		private bool no_First_Number_In_Equation_Single = true;

		private IOperand operand_Sign_Single;
		private IOperand Operand_Sign_Single
		{
			get { return no_operand_Sign_Single == false ? operand_Sign_Single : default(IOperand); ; }
			set
			{
				operand_Sign_Single = value;
				no_operand_Sign_Single = false;
			}
		}
		private bool no_operand_Sign_Single = true;

	}
}
