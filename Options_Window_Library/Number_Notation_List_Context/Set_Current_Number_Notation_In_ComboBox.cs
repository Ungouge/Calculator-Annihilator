using System;
using Common_Library;

namespace Options_Window_Library
{
    partial class Number_Notation_List_Context
    {
        private Number_Notation_List_Item Set_Current_Number_Notation_In_ComboBox(Number_Notation current_Number_Notation)
        {
            foreach (Number_Notation_List_Item item in Number_Notation_List_Items_List)
            {
                if (item.Number_Notation == current_Number_Notation)
                    return item;
            }

            return null;
        }
    }
}

