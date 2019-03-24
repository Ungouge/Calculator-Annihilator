using System;
using Common_Library;

namespace Options_Window_Library
{
    partial class Number_Notation_List_Context
    {
        /// <summary>
        /// Sets texts for list_Item in Number_Notation_Items_List.
        /// </summary>
        public void Set_Number_Notation_Texts(IStandard_Messages_Translate standard_Messages)
        {
            foreach (Number_Notation_List_Item list_Item in Number_Notation_List_Items_List)
            {
                list_Item.Set_Number_Notation_Name(
                    standard_Messages.Translate(list_Item.Number_Notation.ToString() + "_Notation"));
            }
        }
    }
}