using System;
using System.Collections.Generic;

namespace Options_Window_Library
{
    public interface IFont_Size_List_Context
    {
        List<IFont_Size_List_Item> Font_Size_Items_List { get; }

        IFont_Size_List_Item Font_Size_List_ComboBox_SelectedItem { get; set; }
    }
}
