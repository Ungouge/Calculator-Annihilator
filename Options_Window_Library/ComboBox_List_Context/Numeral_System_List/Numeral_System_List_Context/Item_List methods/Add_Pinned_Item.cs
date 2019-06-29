using System;
using System.Collections.Generic;

namespace Options_Window_Library
{
    partial class Numeral_System_List_Context
    {
        /// <summary>
        /// Adds given numeral system to Pinned_Items_List.
        /// </summary>
        internal void Add_Pinned_Item(Pinned_Item_Numeral_System_List New_Item)
        {
            if (Pinned_Items_List.Count > 0)
            {
                int new_Item_Position = 0;

                for (; new_Item_Position < Pinned_Items_List.Count; new_Item_Position++)
                    if (Pinned_Items_List[new_Item_Position].Numeral_System_Code > New_Item.Numeral_System_Code)
                        break;

                Pinned_Items_List.Insert(new_Item_Position, New_Item);
            }
            else
                Pinned_Items_List = new List<Pinned_Item_Numeral_System_List>() { New_Item };
        }
    }
}
