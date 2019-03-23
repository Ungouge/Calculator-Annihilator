using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Options_Library;

namespace Options_Window_Library
{
    partial class Numeral_System_List_Context
    {
        partial class Numeral_System_Items_List
        {
            internal void Remove_Pinned_Item(sbyte numeral_System_Code)
            {
                foreach (Numeral_System_List_Content item in Pinned_Items_List)
                {
                    if (item is Item_Numeral_System_List_Control item_Control)
                    {
                        if (item_Control.Numeral_System_Code == numeral_System_Code)
                        {
                            Pinned_Items_List.Remove(item_Control);

                            break;
                        }
                    }
                }
            }
        }
    }
}
