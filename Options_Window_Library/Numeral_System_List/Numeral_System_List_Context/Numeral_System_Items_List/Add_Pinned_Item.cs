using System;
using System.Collections.Generic;

namespace Options_Window_Library
{
    partial class Numeral_System_List_Context
    {
        partial class Numeral_System_Items_List
        {
            /// <summary>
            /// Adds given numeral system to Pinned_Items_List.
            /// </summary>
            internal void Add_Pinned_Item(Numeral_System_List_Context Numeral_System_List_Context,sbyte numeral_System_Code)
            {
                Item_Numeral_System_List_Control New_Item = Factory.Get_Item(Numeral_System_List_Context, numeral_System_Code);

                if (Pinned_Items_List.Count > 0)
                {
                    int new_Item_Position = 0;

                    for (; new_Item_Position < Pinned_Items_List.Count; new_Item_Position++)
                        if (Pinned_Items_List[new_Item_Position].Numeral_System_Code > numeral_System_Code)
                            break;

                    Pinned_Items_List.Insert(new_Item_Position, New_Item);
                }
                else
                    Pinned_Items_List = new List<Numeral_System_List_Item>() { New_Item };
            }
        }
    }
}
