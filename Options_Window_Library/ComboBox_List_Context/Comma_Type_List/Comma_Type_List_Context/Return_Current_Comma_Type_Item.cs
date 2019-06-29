using System;

namespace Options_Window_Library
{
    partial class Comma_Type_List_Context
    {
        /// <summary>
        /// Returns cuurently selected item in Comma_Type_list_ComboBox.
        /// </summary>
        public IComma_Type_List_Item Return_Current_Comma_Type_Item()
        {
            foreach (IComma_Type_List_Item item_Content in Comma_Type_Items_List)
            {
                if (item_Content is IComma_Type_List_Item Item)
                {
                    return Item;
                }
            }

            return null;
        }
    }
}