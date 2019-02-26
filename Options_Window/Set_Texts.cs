using System;
using Common_Library;

namespace Options_Window
{
    partial class OWXYZ
    {
        internal void Set_Text(Standard_Messages standard_Messages)
        {
            _Number_Notation_List_Context.Set_Number_Notation_Texts(standard_Messages);

            _Font_Size_List_Context.Set_Font_Size_Texts(standard_Messages);

            _Numeral_System_List_Context.Set_Numeral_System_Texts(standard_Messages);
        }
    }
}
