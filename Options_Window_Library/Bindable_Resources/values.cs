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

        public IComma_Type_List_Context Comma_Type_List_Context { get; private set; }

        public INumber_Notation_List_Context Number_Notation_List_Context { get; private set; }

        public ILangauge_List_Context Langauge_List_Context { get; private set; }

        public IFont_Size_List_Context Font_Size_List_Context { get; private set; }

        public INumeral_System_List_Context Numeral_System_List_Context { get; private set; }

        public Thickness TabItem_Margin_Thickness { get; private set; }

        public Thickness ComboBox_ContentSite_Margin { get; private set; }

        public CornerRadius ComboBox_ToggleButton_Border_CornerRadius { get; private set; }
    }
}