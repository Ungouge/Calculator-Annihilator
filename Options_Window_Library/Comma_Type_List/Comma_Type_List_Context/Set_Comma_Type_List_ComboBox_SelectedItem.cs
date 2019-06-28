using System;

namespace Options_Window_Library
{
    partial class Comma_Type_List_Context
    {
        /// <summary>
        /// Returns curently selected item in Comma_Type_List_ComboBox.
        /// </summary>
        public IComma_Type_List_Item Set_Comma_Type_List_ComboBox_SelectedItem()
        {
            foreach (IComma_Type_List_Item item_Content in Comma_Type_Items_List)
                if (item_Content is Comma_Type_List_Item Item)
                    if (Item.Content_Text == Options_Provider.Comma_Type)
                        return Item;

            return null;
        }
    }
}