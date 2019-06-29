using System;

namespace Options_Window_Library
{
    partial class Font_Size_List_Item
    {
        /// <summary>
        /// Sets Font_Size_Name.
        /// </summary>
        internal void Set_Font_Size_Name(string new_Font_Size_Name)
        {
            Font_Size_Name = new_Font_Size_Name;
            On_Property_Change("Font_Size_Name");
        }
    }
}