using System;
using Options_Library;

namespace Options_Window_Library
{
    partial class Numeral_System_List_Context
    {
        internal void Pin_Numeral_System(Item_Numeral_System_List Old_Item)
        {
            sbyte numeral_System_Code = Old_Item.Numeral_System_Code;

            Pinned_Numeral_Systems.Add_Numeral_System(numeral_System_Code);

            Pinned_Item_Numeral_System_List New_Item = Factory.Get_Pinned_Item(numeral_System_Code);

            Add_Pinned_Item(New_Item);

            Reload_Item(New_Item);
            
            On_Property_Change("Numeral_System_List_Items_List");
        }
    }
}
