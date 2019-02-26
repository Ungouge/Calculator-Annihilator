using System;
using Common_Library;

namespace Options_Window
{
    partial class OWXYZ
    {
        public partial class Bindable_Resources
        {
            public Bindable_Resources(OWXYZ _OptionsWindow)
            {
                OptionsWindow = _OptionsWindow;

                Options_Text_FontSize = Set_Options_Text_FontSize();

                Set_Text(OptionsWindow.Options.Standard_Messages);

                ComboBox_List_Image_Height = Set_ComboBox_List_Image_Height();

                ComboBox_Element_Height = ComboBox_List_Image_Height + 12 ;

                ComboBox_Element_Width = Set_ComboBox_List_Image_Width();
            }
        }
    }
}
