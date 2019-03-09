using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Options_Window
{
    partial class Numeral_System_List_Context
    {
        class Label_Pinned_Numeral_System_List_Item: Label_Numeral_System_List_Item
        {
            public Label_Pinned_Numeral_System_List_Item(OWXYZ _OptionsWindow) : base(_OptionsWindow)
            {
                Numeral_System_List_Content_Text = _OptionsWindow.Options.Standard_Messages.Translate("Pinned_Numeral_system");
            }
        }
    }
}
