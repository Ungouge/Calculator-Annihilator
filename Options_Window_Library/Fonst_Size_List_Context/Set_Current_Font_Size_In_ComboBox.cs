using System;
using Common_Library;

namespace Options_Window_Library
{
    partial class Font_Size_List_Context
    {
        private Font_Size_List_Item Set_Current_Font_Size_In_ComboBox(Font_Size_Type current_Font_Size)
        {
            foreach (Font_Size_List_Item item in Font_Size_List_Items_List)
            {
                if (item.Font_Size == current_Font_Size)
                    return item;
            }

            return null;
        }
    }
}

