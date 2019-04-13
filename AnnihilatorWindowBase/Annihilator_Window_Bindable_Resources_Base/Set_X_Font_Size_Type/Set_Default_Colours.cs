using System;
using System.Windows;

namespace AnnihilatorWindowBase
{
    partial class Annihilator_Window_Bindable_Resources_Base
    {
        private void Set_Default_Colours()
        {
            Background_Colour = Get_SystemColors_WindowTextBrush;

            Foreground_Colour = Get_SystemColors_WindowBrush;

            Control_Background_Colour = Get_SystemColors_ControlBrush;

            Control_Border_Colour = Get_SystemColors_ActiveBorderBrush;
        }
    }
}