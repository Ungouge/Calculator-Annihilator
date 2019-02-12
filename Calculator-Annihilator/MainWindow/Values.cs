using System;

namespace Calculator_Annihilator
{
	partial class MainWindow
	{
        internal Options options;
        
        private Calc Calc = new Calc();

        private Equation Equation;

        internal Bindable_Resources GUI_Bindable_Resources;
        
        internal Back_Parser_Fascede Back_Parser;

        private Parser Parser
        {
            get
            {
                return options.Parser;
            }
        }

        protected internal Numeral_System Current_Numeral_System
        {
            get
            {
                return options.Current_Numeral_System;
            }
        }

        public sbyte Numeral_System_Type //check class Numerical_System for description of exotic numeral system
		{
			get
			{
				return options.Current_Numeral_System.System_Type;
			}
		}

		public char[] Numerical_System_Signs
		{
			get
			{
				return options.Current_Numeral_System.System_Digits;
			}
        }
        
        internal Languages Current_Language
        {
            get
            {
                return options.Current_Language;
            }
            set
            {
                options.Current_Language = value;
            }
        }
        internal Standard_Messages Standard_Messages
        {
            get
            {
                return options.Standard_Messages;
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
