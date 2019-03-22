using System;
using Common_Library;

namespace Options_Window_Library
{
    partial class Number_Notation_List_Context
    {
        internal void Set_Number_Notation_Texts(IStandard_Messages_Translate standard_Messages)
        {
            foreach (Number_Notation_List_Item list_Item in Number_Notation_List_Items_List)
            {
                list_Item.Number_Notation_Size_Name(
                    standard_Messages.Translate(list_Item.Number_Notation.ToString() + "_Notation"));
            }
        }
    }
}