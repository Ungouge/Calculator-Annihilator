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

                Langauge_List_Items_List = Set_Languges_List_Items();

                Language_List_ComboBox_SelectedItem =
                    Set_Current_Language_In_ComboBox(Options_Window.Options.Current_Language);

                Font_Size_List_Items_List = Set_Font_Size_List_Items();

                Font_Size_List_ComboBox_SelectedItem =
                    Set_Current_Font_Size_In_ComboBox(Options_Window.Options.Font_Size_Type);

                Set_Text(Options_Window.Options.Standard_Messages);

                ComboBox_List_Image_Height = Set_ComboBox_List_Image_Height();

                ComboBox_Element_Height = ComboBox_List_Image_Height + 12 ;
            }
        }
    }
}
