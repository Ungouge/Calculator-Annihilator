using System;

namespace Options_Window_Library
{
    partial class Item_Numeral_System_List
    {
        /// <summary>
        /// Sets Numeral_System_Name.
        /// </summary>
        internal void Set_Numeral_System_Name(string new_Numeral_System_Name)
        {
            Content_Text = new_Numeral_System_Name;

            On_Property_Change("Content_Text");
        }
    }
}
