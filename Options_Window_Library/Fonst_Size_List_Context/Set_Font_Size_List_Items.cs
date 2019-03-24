using System;
using System.Collections.Generic;
using Common_Library;

namespace Options_Window_Library
{
    partial class Font_Size_List_Context
    {
        /// <summary>
        /// Sets list of Font_Size_List_Content.
        /// </summary>
        private List<Font_Size_List_Item> Set_Font_Size_List_Items()
        {
            List<Font_Size_List_Item> Output_Items_List = new List<Font_Size_List_Item>();

            foreach (Font_Size_Type font_Size in (Font_Size_Type[])Enum.GetValues(typeof(Font_Size_Type)))
            {
                Output_Items_List.Add(new Font_Size_List_Item(Standard_Messages, font_Size));
            }

            return Output_Items_List;
        }
    }
}
