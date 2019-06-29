using System;
using Options_Library;

namespace Options_Window_Library
{
    partial class Numeral_System_List_Context
    {
        internal void Unpin_Numeral_System(Pinned_Item_Numeral_System_List Old_Item)
        {
            sbyte numeral_System_Code = Old_Item.Numeral_System_Code;

            Pinned_Numeral_Systems.Remove_Numeral_System(numeral_System_Code);

            Pinned_Items_List.Remove(Old_Item);

            Reload_Item(Factory.Get_Item(numeral_System_Code));
            
            On_Property_Change("Numeral_System_List_Items_List");
        }
    }
}
