using System;
using Common_Library;

namespace Options_Window
{
    partial class Numeral_System_List_Context
    {
        private Numeral_System_List_Item Find_Numeral_System_Item(sbyte numeral_System_Code)
        {
            foreach (Numeral_System_List_Item item in Numeral_System_List_Items_List)
                if ((item as Numeral_System_List_Item).Numeral_System_Code == numeral_System_Code)
                    return item;

            throw new NoSuchNumericalSystemException();
        }
    }
}

