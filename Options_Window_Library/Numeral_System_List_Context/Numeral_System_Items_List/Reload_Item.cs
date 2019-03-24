using System;

namespace Options_Window_Library
{
    partial class Numeral_System_List_Context
    {
        partial class Numeral_System_Items_List
        {
            /// <summary>
            /// Reinitialises item in Items_List with given numerals sytem to current pinned/unpinned item control.
            /// </summary>
            internal void Reload_Item(Numeral_System_List_Context Numeral_System_List_Context,sbyte numeral_System_Code)
            {
                foreach (Numeral_System_List_Content item in Items_List)
                {
                    if (item is Item_Numeral_System_List_Control item_Control)
                    {
                        if (item_Control.Numeral_System_Code == numeral_System_Code)
                        {
                            Items_List[Items_List.IndexOf(item_Control)] = Factory.Get_Item(Numeral_System_List_Context, numeral_System_Code);

                            return;
                        }
                    }
                }
                
            }
        }
    }
}
