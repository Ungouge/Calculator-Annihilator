using System;
using Common_Library;

namespace AnnihilatorWindowBase
{
    partial class Annihilator_Window_Bindable_Resources_Base
    {
        private void Set_High_Contrast_Font_Size_Type()
        {
            Text_FontSize = 48;

            Corner_Radius = 2;

            Border_Thickness = 4;

            Pressed_Scale_Factor = 1;

            Highlighted_Corner_Radius = Corner_Radius;

            Highlighted_Border_Thickness = Corner_Radius;

            if (Colour_Palette_Type is Colour_Palette_Type.Colour_Blind)
                Set_Colour_Blind_Colours();
            else
                Set_High_Contrast_Colours();
        }
    }
}