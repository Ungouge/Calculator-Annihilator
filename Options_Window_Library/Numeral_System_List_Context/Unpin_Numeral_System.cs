using System;
using Options_Library;

namespace Options_Window_Library
{
    partial class Numeral_System_List_Context
    {
        internal void Unpin_Numeral_System(sbyte numeral_System_Code)
        {
            Pinned_Numeral_Systems.Remove_Numeral_System(numeral_System_Code);

            _Numeral_System_List_Items_List.Remove_Pinned_Item(numeral_System_Code);
            
            _Numeral_System_List_Items_List.Reload_Item(numeral_System_Code);

            On_Property_Change("Numeral_System_List_Items_List");
        }
    }
}
