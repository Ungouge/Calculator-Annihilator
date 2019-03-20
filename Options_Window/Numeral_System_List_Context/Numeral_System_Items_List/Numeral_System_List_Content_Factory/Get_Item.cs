﻿using System;
using Options_Library;

namespace Options_Window
{
    partial class Numeral_System_List_Context
    {
        partial class Numeral_System_Items_List
        {
            partial class Numeral_System_List_Content_Factory
            {
                internal Item_Numeral_System_List_Control Get_Item(sbyte numeral_System_Code)
                {
                    if (Pinned_Numeral_Systems.Is_Numeral_sytem_Pinned(numeral_System_Code) == false)
                        return new Item_Numeral_System_List_Control(OptionsWindow, numeral_System_Code);

                    return new Pinned_Item_Numeral_System_List_Control(OptionsWindow, numeral_System_Code);
                }
            }
        }
    }
}