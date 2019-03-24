using System;
using Common_Library;

namespace Calculator_Annihilator
{
    partial class Options
    {
        public void Set_Font_Size_Type(Font_Size_Type new_Font_Size_Type)
        {
            Font_Size_Type = new_Font_Size_Type;

            Current_MainWindow.GUI_Bindable_Resources.Push_Recalculations();
        }
    }
}
