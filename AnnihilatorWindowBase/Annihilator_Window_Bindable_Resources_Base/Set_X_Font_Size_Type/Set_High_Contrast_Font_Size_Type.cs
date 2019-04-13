using System;
using System.Windows;

namespace AnnihilatorWindowBase
{
    partial class Annihilator_Window_Bindable_Resources_Base
    {
        private void Set_High_Contrast_Font_Size_Type()
        {
            Text_FontSize = 48;
            
            Background_Colour = Get_High_Contrast_WindowBrush;

            Foreground_Colour = Get_High_Contrast_WindowTextBrush;

            Control_Background_Colour = Get_High_Contrast_ControlBrush;

            Control_Border_Colour = Get_High_Contrast_ActiveBorderBrush;
        }
    }
}