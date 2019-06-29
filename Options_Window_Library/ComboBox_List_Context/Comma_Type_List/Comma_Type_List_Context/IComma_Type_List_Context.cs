using System;
using System.Collections.Generic;

namespace Options_Window_Library
{
    internal interface IComma_Type_List_Context
    {
        IComma_Type_List_Item Comma_Type_List_ComboBox_SelectedItem { get; set; }

        List<IComma_Type_List_Item> Comma_Type_Items_List { get; }

        IComma_Type_List_Item Return_Current_Comma_Type_Item();
    }
}
