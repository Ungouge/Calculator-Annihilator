using System;
using Common_Library;

namespace Options_Window_Library
{
    partial class Font_Size_List_Context
    {
        internal void Set_Font_Size_Texts(IStandard_Messages_Translate Standard_Messages)
        {
            foreach (Font_Size_List_Item list_Item in Font_Size_List_Items_List)
            {
                list_Item.Set_Font_Size_Name(
                    Standard_Messages.Translate(list_Item.Font_Size.ToString() + "_Font_Size"));
            }
        }
    }
}