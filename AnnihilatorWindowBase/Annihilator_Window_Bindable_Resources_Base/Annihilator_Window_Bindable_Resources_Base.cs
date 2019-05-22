using System;
using Common_Library;

namespace AnnihilatorWindowBase
{
    public abstract partial class Annihilator_Window_Bindable_Resources_Base
    {
        public Annihilator_Window_Bindable_Resources_Base(Font_Size_Type _Font_Size_Type, Colour_Palette_Type _Colour_Palette_Type)
        {
            Font_Size_Type = _Font_Size_Type;

            Colour_Palette_Type = _Colour_Palette_Type;

            Set_Font_Size_Type();
        }
    }
}
