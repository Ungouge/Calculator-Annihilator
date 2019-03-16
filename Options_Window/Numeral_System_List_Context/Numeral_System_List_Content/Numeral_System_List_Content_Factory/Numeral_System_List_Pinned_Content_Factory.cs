using System;
using Common_Library;

namespace Options_Window
{
    internal class Numeral_System_List_Pinned_Content_Factory: Numeral_System_List_Content_Factory
    {
        public Numeral_System_List_Pinned_Content_Factory(Standard_Messages _Standard_Messages): base(
            _Standard_Messages.Translate("Pinned_Numeral_system"))
        { }
    }
}
