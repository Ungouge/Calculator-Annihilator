using System;
using System.Windows;
using System.Windows.Media;
using Common_Library;

namespace AnnihilatorWindowBase
{
    public partial class Annihilator_Window_Bindable_Resources_Base
    {
        protected readonly Font_Size_Type Font_Size_Type;

        protected readonly Colour_Palette_Type Colour_Palette_Type;

        public Color Background_Colour { get; protected set; }

        public Color Foreground_Colour { get; protected set; }
        
        public Color Control_Background_Colour { get; protected set; }

        public Color Control_Border_Colour { get; protected set; }

        public Color Highlighted_Control_Background_Colour { get; protected set; }

        public Color Highlighted_Control_Border_Colour { get; protected set; }

        public double Text_FontSize { get; protected set; }

        public double Window_Height { get; protected set; }

        public double Window_Width { get; protected set; }

        public double Corner_Radius { get; protected set; }

        public double Border_Thickness { get; protected set; }

        public double Highlighted_Corner_Radius { get; protected set; }

        public double Highlighted_Border_Thickness { get; protected set; }

        protected Set_Element_Style_Delegate Set_Element_Style_Delegate_Method;
    }
}
