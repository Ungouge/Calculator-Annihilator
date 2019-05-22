using System;
using System.Windows.Media;

namespace AnnihilatorWindowBase
{
    partial class Annihilator_Window_Bindable_Resources_Base
    {
        private readonly Color High_Contrast_WindowColour = Brushes.Black.Color;

        private readonly Color High_Contrast_WindowTextColour = Brushes.Yellow.Color;

        private readonly Color High_Contrast_ActiveBorderColour = Brushes.Teal.Color;

        private readonly Color High_Contrast_ControlColour = Brushes.Gray.Color;

        private readonly Color High_Contrast_Highlighted_Background_Colour = Brushes.Yellow.Color;

        private readonly Color High_Contrast_Highlighted_Border_Colour = Brushes.Gray.Color;

        private void Set_High_Contrast_Colours()
        {
            Background_Colour = High_Contrast_WindowColour;

            Foreground_Colour = High_Contrast_WindowTextColour;

            Control_Background_Colour = High_Contrast_ControlColour;

            Control_Border_Colour = High_Contrast_ActiveBorderColour;

            Highlighted_Control_Background_Colour = High_Contrast_Highlighted_Background_Colour;

            Highlighted_Control_Border_Colour = High_Contrast_Highlighted_Border_Colour;
        }
    }
}