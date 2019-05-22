using System;
using System.Windows.Media;

namespace AnnihilatorWindowBase
{
    partial class Annihilator_Window_Bindable_Resources_Base
    {
        private readonly Color Colour_Blind_WindowColour = Brushes.Orange.Color;

        private readonly Color Colour_Blind_WindowTextColour = Brushes.Blue.Color;

        private readonly Color Colour_Blind_ActiveBorderColour = Brushes.Green.Color;

        private readonly Color Colour_Blind_ControlColour = Brushes.Red.Color;

        private readonly Color Colour_Blind_Highlighted_Background_Colour = Brushes.Yellow.Color;

        private readonly Color Colour_Blind_Highlighted_Border_Colour = Brushes.White.Color;

        private void Set_Colour_Blind_Colours()
        {
            Background_Colour = Colour_Blind_WindowColour;

            Foreground_Colour = Colour_Blind_WindowTextColour;

            Control_Background_Colour = Colour_Blind_ControlColour;

            Control_Border_Colour = Colour_Blind_ActiveBorderColour;

            Highlighted_Control_Background_Colour = Colour_Blind_Highlighted_Background_Colour;

            Highlighted_Control_Border_Colour = Colour_Blind_Highlighted_Border_Colour;
        }
    }
}