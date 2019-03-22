using System;
using System.Collections.Generic;
using Common_Library;

namespace Options_Window_Library
{
    partial class Number_Notation_List_Context
    {
        private List<Number_Notation_List_Item> Set_Number_Notation_List_Items()
        {
            List<Number_Notation_List_Item> Output_Items_List = new List<Number_Notation_List_Item>();

            foreach (Number_Notation number_Notation in (Number_Notation[])Enum.GetValues(typeof(Number_Notation)))
            {
                Output_Items_List.Add(new Number_Notation_List_Item(Standard_Messages, number_Notation));
            }

            return Output_Items_List;
        }
    }
}
