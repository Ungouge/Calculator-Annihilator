using System;

namespace Options_Window_Library
{
    partial class Font_Size_List_Context
    {
        partial class Font_Size_List_Item
        {
            internal void Set_Font_Size_Name(string new_Font_Size_Name)
            {
                Font_Size_Name = new_Font_Size_Name;
                On_Property_Change("Font_Size_Name");
            }
        }
    }
}