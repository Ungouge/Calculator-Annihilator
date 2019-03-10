using System;
using Common_Library;

namespace Options_Library
{
    partial class Options_Storage
    {
        public Calculator_Mode Calculator_Mode { get; set; }

        public Calculation_Method Calculation_Method { get; set; }

        public double Initial_Height { get; set; }

        public double Initial_Width { get; set; }

        public Number_Notation Number_Notation { get; set; }
        
        public Font_Size_Type Font_Size_Type { get; set; }
        
        public sbyte Numeral_System_Code { get; protected set; }
        
        public sbyte[] Pined_Numeral_Systems { get; protected set; }
        
        public Languages Current_Language { get; protected set; }

        public string Comma_Type { get; protected set; }
    }
}