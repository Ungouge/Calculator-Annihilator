using System;
using Options_Library;
using System.Collections.Generic;

namespace Options_Window_Library
{
    partial class Numeral_System_List_Context
    {
        /// <summary>
        /// Sets list of pinned Numeral_System or empty list if there is no pinned Numeral_Systems.
        /// </summary>
        private List<Pinned_Item_Numeral_System_List> Set_Pinned_Numeral_System_List()
        {
            List<Pinned_Item_Numeral_System_List> Output_Items_List = new List<Pinned_Item_Numeral_System_List>();

            if (Pinned_Numeral_Systems.Get_Numeral_Systems_Codes.Length > 0)
            {
                foreach (Item_Numeral_System_List Item in Items_List)
                {
                    if (Item is Pinned_Item_Numeral_System_List Pinned_Item)
                    {
                        Output_Items_List.Add(Pinned_Item);
                    }
                }
                //foreach (sbyte numeral_System in Pinned_Numeral_Systems.Get_Numeral_Systems_Codes)
                //{
                //    IItem_Numeral_System_List item = Factory.Get_Item( numeral_System);

                //    if (item is Pinned_Item_Numeral_System_List pinned_Item)
                //        Output_Items_List.Add(pinned_Item);
                //}
            }

            return Output_Items_List;
        }
    }
}
