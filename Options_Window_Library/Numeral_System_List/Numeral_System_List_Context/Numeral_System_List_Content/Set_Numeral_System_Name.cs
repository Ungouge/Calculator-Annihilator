using System;

namespace Options_Window_Library
{
    partial class Numeral_System_List_Item
    {
        /// <summary>
        /// Sets Numeral_System_Name.
        /// </summary>
        internal void Set_Numeral_System_Name(string new_Numeral_System_Name)
        {
            Content_Text = new_Numeral_System_Name;

            On_Property_Change("Numeral_System_List_Item_Text");
        }
    }
}
