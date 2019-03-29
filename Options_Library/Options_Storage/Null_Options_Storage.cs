using System;
using Common_Library;

namespace Options_Library
{
    public class Null_Options_Storage: IOptions_Storage
    {
        public Calculator_Mode Calculator_Mode
        {
            get { throw new ArgumentNullException(); }
        }

        public Calculation_Method Calculation_Method
        {
            get { throw new ArgumentNullException(); }
        }

        public double Initial_Height
        {
            get { throw new ArgumentNullException(); }
        }

        public double Initial_Width
        {
            get { throw new ArgumentNullException(); }
        }

        public Number_Notation Number_Notation
        {
            get { throw new ArgumentNullException(); }
        }

        public Font_Size_Type Font_Size_Type
        {
            get { throw new ArgumentNullException(); }
        }

        public sbyte Numeral_System_Code
        {
            get { throw new ArgumentNullException(); }
        }

        public Languages Current_Language
        {
            get { throw new ArgumentNullException(); }
        }

        public string Comma_Type
        {
            get { throw new ArgumentNullException(); }
        }

        public string[] Commas_Type_Array
        {
            get { throw new ArgumentNullException(); }
        }
    }
}