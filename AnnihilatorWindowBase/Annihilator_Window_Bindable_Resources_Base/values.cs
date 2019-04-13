using System;
using System.Windows.Media;
using Common_Library;

namespace AnnihilatorWindowBase
{
    public partial class Annihilator_Window_Bindable_Resources_Base
    {
        protected readonly Font_Size_Type Font_Size_Type;

        public Color Background_Colour { get; set; }

        public Color Foreground_Colour { get; set; }

        public Color Control_Background_Colour { get; set; }

        public Color Control_Border_Colour { get; set; }

        //public Color Y_Colour { get; set; }

        public double Text_FontSize { get; set; }

        public double Window_Height { get; set; }

        public double Window_Width { get; set; }
    }
}
