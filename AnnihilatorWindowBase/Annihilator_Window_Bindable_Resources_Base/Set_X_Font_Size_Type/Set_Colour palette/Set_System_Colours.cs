using System;
using System.Windows;

namespace AnnihilatorWindowBase
{
    partial class Annihilator_Window_Bindable_Resources_Base
    {
        private void Set_System_Colours()
        {
            Background_Colour = SystemColors.WindowColor;

            Foreground_Colour = SystemColors.WindowTextColor;

            Control_Background_Colour = SystemColors.ControlColor;

            Control_Border_Colour = SystemColors.ActiveBorderColor;

            Highlighted_Control_Background_Colour = SystemColors.HighlightColor + SystemColors.ControlColor;

            Highlighted_Control_Border_Colour = SystemColors.ActiveBorderColor;
        }
    }
}