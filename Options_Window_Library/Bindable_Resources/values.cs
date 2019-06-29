using System;
using System.Windows;
using Common_Library;

namespace Options_Window_Library
{
    partial class Bindable_Resources // Values
    {
        public double ComboBox_Element_Height { get; set; }

        public double ComboBox_Element_Width { get; set; }

        public double ComboBox_Text_Width { get; set; }

        public double ComboBox_List_Image_Size { get; private set; }

        public double ComboBox_ToggleButton_Arrow_Width { get; private set; }

        public double TabItem_Grid_Height { get; private set; }

        private Comma_Type_List_Context _Comma_Type_List_Context { get; set; }

        private Number_Notation_List_Context _Number_Notation_List_Context { get; set; }

        private Langauge_List_Context _Langauge_List_Context { get; set; }

        private Font_Size_List_Context _Font_Size_List_Context { get; set; }

        private Numeral_System_List_Context _Numeral_System_List_Context { get; set; }

        public Thickness TabItem_Margin_Thickness { get; private set; }

        public Thickness ComboBox_ContentSite_Margin { get; private set; }

        public CornerRadius ComboBox_ToggleButton_Border_CornerRadius { get; private set; }
    }
}