using System;
using Options_Library;

namespace Options_Window_Library
{
    partial class Numeral_System_List_Context
    {
        partial class Numeral_System_List_Content_Factory
        {
            /// <summary>
            /// Gets proper Item_Numeral_System_List_Control for given numeral system.
            /// </summary>
            internal Item_Numeral_System_List Get_Item(sbyte numeral_System_Code)
            {
                if (Pinned_Numeral_Systems.Is_Numeral_System_Pinned(numeral_System_Code) == false)
                    return new Item_Numeral_System_List(Numeral_System_List_Context, numeral_System_Code, Standard_Messages);

                return new Pinned_Item_Numeral_System_List(Numeral_System_List_Context, numeral_System_Code, Standard_Messages);
            }

            /// <summary>
            /// Gets Pinned_Item_Numeral_System_List_Control for given numeral system if it is pinned.
            /// </summary>
            internal Pinned_Item_Numeral_System_List Get_Pinned_Item( sbyte numeral_System_Code)
            {
                if (Pinned_Numeral_Systems.Is_Numeral_System_Pinned(numeral_System_Code) == false)
                    return null;

                return new Pinned_Item_Numeral_System_List(Numeral_System_List_Context, numeral_System_Code);
            }
        }
    }
}