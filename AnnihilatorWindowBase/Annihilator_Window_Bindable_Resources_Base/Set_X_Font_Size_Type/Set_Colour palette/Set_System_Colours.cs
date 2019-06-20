using System;
using System.Windows;
using System.Windows.Media;

namespace AnnihilatorWindowBase
{
    partial class Annihilator_Window_Bindable_Resources_Base
    {
        private void Set_System_Colours()
        {
            Background_Colour = new SolidColorBrush(SystemColors.WindowColor);

            Foreground_Colour = new SolidColorBrush(SystemColors.WindowTextColor);

            Control_Background_Colour = new SolidColorBrush(SystemColors.ControlColor);

            Control_Border_Colour = new SolidColorBrush(SystemColors.ActiveBorderColor);

            Highlighted_Foreground_Colour = new SolidColorBrush(SystemColors.WindowTextColor);

            Highlighted_Control_Background_Colour = new SolidColorBrush(SystemColors.HighlightColor + SystemColors.ControlColor);

            Highlighted_Control_Border_Colour = new SolidColorBrush(SystemColors.ActiveBorderColor);
        }
    }
}