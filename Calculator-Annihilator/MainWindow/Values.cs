using System;
using Common_Library;

namespace Calculator_Annihilator
{
	partial class MainWindow
	{
        internal Options Options;

        public IOptions_Provider Get_Options
        {
            get
            {
                return Options;
            }
        }
        
        private Calc Calc = new Calc();

        private Equation Equation;

        internal Bindable_Resources GUI_Bindable_Resources;
        
        internal Back_Parser_Fascede Back_Parser;

        private Parser Parser
        {
            get
            {
                return Options.Parser;
            }
        }

        protected internal Numeral_System Current_Numeral_System
        {
            get
            {
                return Options.Current_Numeral_System;
            }
        }

        public sbyte Numeral_System_Type //check class Numerical_System for description of exotic numeral system
		{
			get
			{
				return Options.Current_Numeral_System.System_Type;
			}
            private set
            {
                Options.Set_Numeral_System(value);
            }
		}

		public char[] Numerical_System_Signs
		{
			get
			{
				return Options.Current_Numeral_System.System_Digits;
			}
        }
        
        internal Languages Current_Language
        {
            get
            {
                return Options.Current_Language;
            }
            set
            {
                Options.Set_Language(value);
            }
        }
        internal Standard_Messages Standard_Messages
        {
            get
            {
                return Options.Standard_Messages;
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
