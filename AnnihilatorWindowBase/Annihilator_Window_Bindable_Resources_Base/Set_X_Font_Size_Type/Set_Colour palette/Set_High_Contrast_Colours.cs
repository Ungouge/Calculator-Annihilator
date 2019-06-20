using System;
using System.Windows.Media;

namespace AnnihilatorWindowBase
{
    partial class Annihilator_Window_Bindable_Resources_Base
    {
        private readonly SolidColorBrush High_Contrast_WindowColour = Brushes.Black;

        private readonly SolidColorBrush High_Contrast_WindowTextColour = Brushes.Yellow;

        private readonly SolidColorBrush High_Contrast_ActiveBorderColour = Brushes.Teal;

        private readonly SolidColorBrush High_Contrast_ControlColour = Brushes.Gray;
        
        private readonly SolidColorBrush High_Contrast_Highlighted_Foreground_Colour = Brushes.DarkBlue;

        private readonly SolidColorBrush High_Contrast_Highlighted_Background_Colour = Brushes.Yellow;

        private readonly SolidColorBrush High_Contrast_Highlighted_Border_Colour = Brushes.Gray;

        private void Set_High_Contrast_Colours()
        {
            Background_Colour = High_Contrast_WindowColour;

            Foreground_Colour = High_Contrast_WindowTextColour;

            Control_Background_Colour = High_Contrast_ControlColour;

            Control_Border_Colour = High_Contrast_ActiveBorderColour;

            Highlighted_Foreground_Colour = High_Contrast_Highlighted_Foreground_Colour;

            Highlighted_Control_Background_Colour = High_Contrast_Highlighted_Background_Colour;

            Highlighted_Control_Border_Colour = High_Contrast_Highlighted_Border_Colour;
        }
    }
}