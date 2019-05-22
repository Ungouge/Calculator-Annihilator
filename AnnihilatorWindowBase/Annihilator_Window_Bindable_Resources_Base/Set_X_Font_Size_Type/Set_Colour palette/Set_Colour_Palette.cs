using System;
using System.Windows;
using Common_Library;

namespace AnnihilatorWindowBase
{
    partial class Annihilator_Window_Bindable_Resources_Base
    {
        private void Set_Colour_Palette()
        {
            switch (Colour_Palette_Type)
            {
                case Colour_Palette_Type.System:
                    Set_System_Colours();
                    break;
                case Colour_Palette_Type.Colour_Blind:
                    Set_Colour_Blind_Colours();
                    break;
                default:
                    Set_High_Contrast_Colours();
                    break;
            }
        }
    }
}
