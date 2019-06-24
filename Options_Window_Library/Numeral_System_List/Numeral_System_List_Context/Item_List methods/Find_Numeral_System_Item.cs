using System;
using Common_Library;

namespace Options_Window_Library
{
    partial class Numeral_System_List_Context
    {
        /// <summary>
        /// Finds and returns item with given numeral system code.
        /// </summary>
        internal Item_Numeral_System_List Find_Numeral_System_Item(sbyte numeral_System_Code)
        {
            foreach (Item_Numeral_System_List List_Item in Items_List)
                if (List_Item.Numeral_System_Code == numeral_System_Code)
                    return List_Item;

            throw new NoSuchNumericalSystemException();
        }
    }
}

