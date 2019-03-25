using System;
using Common_Library;

namespace Calculator_Annihilator_Library
{
    partial class Options
    {
        public void Set_Font_Size_Type(Font_Size_Type new_Font_Size_Type)
        {
            Font_Size_Type = new_Font_Size_Type;

            MainWindow.Push_GUI_Recalculation();
        }
    }
}
