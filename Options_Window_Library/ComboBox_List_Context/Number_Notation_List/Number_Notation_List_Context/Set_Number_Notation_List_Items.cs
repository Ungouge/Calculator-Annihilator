using System;
using System.Collections.Generic;
using Common_Library;

namespace Options_Window_Library
{
    partial class Number_Notation_List_Context
    {
        /// <summary>
        /// Sets list of Number_Notation_List_Content.
        /// </summary>
        private List<INumber_Notation_List_Item> Set_Number_Notation_List_Items(IStandard_Messages_Translate Standard_Messages)
        {
            List<INumber_Notation_List_Item> Output_Items_List = new List<INumber_Notation_List_Item>();

            foreach (Number_Notation number_Notation in (Number_Notation[])Enum.GetValues(typeof(Number_Notation)))
            {
                Output_Items_List.Add(new Number_Notation_List_Item(Standard_Messages, number_Notation));
            }

            return Output_Items_List;
        }
    }
}
