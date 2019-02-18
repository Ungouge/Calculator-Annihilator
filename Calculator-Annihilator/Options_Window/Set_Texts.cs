using System;

namespace Calculator_Annihilator
{
    partial class Options_Window
    {
        internal void Set_Text(Standard_Messages standard_Messages)
        {
            _Number_Notation_List_Context.Set_Number_Notation_Texts(standard_Messages);

            _Font_Size_List_Context.Set_Font_Size_Texts(standard_Messages);
        }
    }
}
