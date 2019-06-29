using System;

namespace Options_Window_Library
{
    partial class Numeral_System_List_Context
    {
        private void Reload_Item(Item_Numeral_System_List New_Item)
        {
            int item_Position = 0;

            for (; item_Position < Items_List.Count; item_Position++)
            {
                if (Items_List[item_Position].Numeral_System_Code == New_Item.Numeral_System_Code)
                    break;
            }

            Items_List[item_Position] = New_Item;
        }
    }
}
