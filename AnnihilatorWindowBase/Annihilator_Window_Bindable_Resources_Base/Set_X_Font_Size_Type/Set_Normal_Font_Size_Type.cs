using System;
using System.Windows;

namespace AnnihilatorWindowBase
{
    partial class Annihilator_Window_Bindable_Resources_Base
    {
        private void Set_Normal_Font_Size_Type()
        {
            Text_FontSize = 18;

            Corner_Radius = 15e-1;

            Border_Thickness = 3;

            Highlighted_Corner_Radius = Corner_Radius;

            Highlighted_Border_Thickness = Corner_Radius;

            Set_Colour_Palette();
        }
    }
}
