using System;
using System.ComponentModel;

namespace Options_Window_Library
{
    partial class Comma_Type_List_Context
    {
        /// <summary>
        /// Returns cuurently selected item in Comma_Type_list_ComboBox.
        /// </summary>
        /// <returns></returns>
        public Item_Comma_Type_Control Return_Current_Comma_Type_Item()
        {
            foreach (Comma_Type_List_Content item_Content in Comma_Type_Items_List)
            {
                if (item_Content is Item_Comma_Type_Control item_Control)
                {
                    return item_Control;
                }
            }

            return null;
        }
    }
}