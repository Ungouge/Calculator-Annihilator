﻿using System;
using Common_Library;

namespace Options_Window
{
    partial class Numeral_System_List_Context
    {
        private Item_Numeral_System_List_Control Find_Numeral_System_Item(sbyte numeral_System_Code)
        {
            foreach (Numeral_System_List_Content content in Numeral_System_List_Items_List)
                if (content is Item_Numeral_System_List_Control list_Control )
                    if (list_Control.Numeral_System_Code == numeral_System_Code)
                        return list_Control;

            throw new NoSuchNumericalSystemException();
        }
    }
}

