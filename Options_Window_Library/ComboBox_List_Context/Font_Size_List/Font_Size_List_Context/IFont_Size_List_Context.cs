using System;
using System.Collections.Generic;
using Common_Library;

namespace Options_Window_Library
{
    public interface IFont_Size_List_Context
    {
        List<Font_Size_List_Item> Font_Size_Items_List { get; }

        Font_Size_List_Item Font_Size_List_ComboBox_SelectedItem { get; set; }

        void Set_Font_Size_Texts(IStandard_Messages_Translate Standard_Messages);
    }
}
