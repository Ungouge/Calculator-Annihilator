using System;

namespace Calculator_Annihilator
{
    partial class Options_Window
    {
        public partial class Bindable_Resources
        {
            public Bindable_Resources(Options_Window _Options_Window)
            {
                Options_Window = _Options_Window;

                Options_Text_FontSize = Set_Options_Text_FontSize();

                Set_Text(Options_Window.Options.Standard_Messages);

                ComboBox_List_Image_Height = Set_ComboBox_List_Image_Height();

                ComboBox_Element_Height = ComboBox_List_Image_Height + 12 ;

                ComboBox_Element_Width = Set_ComboBox_List_Image_Width();
            }
        }
    }
}
