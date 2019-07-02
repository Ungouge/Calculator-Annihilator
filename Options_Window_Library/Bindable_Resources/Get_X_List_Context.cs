using System;
using System.Windows;
using Common_Library;

namespace Options_Window_Library
{
    partial class Bindable_Resources // Get_X_List_Context
    {
        public IComma_Type_List_Context Comma_Type_List_Context
        {
            get
            {
                return _Comma_Type_List_Context;
            }
        }

        public INumber_Notation_List_Context Number_Notation_List_Context
        {
            get
            {
                return _Number_Notation_List_Context;
            }
        }

        public ILangauge_List_Context Langauge_List_Context
        {
            get
            {
                return _Langauge_List_Context;
            }
        }

        public IFont_Size_List_Context Font_Size_List_Context
        {
            get
            {
                return _Font_Size_List_Context;
            }
        }

        public INumeral_System_List_Context Numeral_System_List_Context
        {
            get
            {
                return _Numeral_System_List_Context;
            }
        }

        public ICalculator_Mode_List_Context Calculator_Mode_List_Context
        {
            get
            {
                return _Calculator_Mode_List_Context;
            }
        }

        public ICalculation_Method_List_Context Calculation_Method_List_Context
        {
            get
            {
                return _Calculation_Method_List_Context;
            }
        }
    }
}
