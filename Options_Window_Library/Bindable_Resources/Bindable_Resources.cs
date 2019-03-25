using System;
using IOptionsWindow_Parameters;

namespace Options_Window_Library
{
    /// <summary>
    /// Provides data and properties for that can be binded in OptionsWindow.
    /// </summary>
    public partial class Bindable_Resources
    {
        /// <summary>
        /// Constructs new instance of Bindable_Resources for given OptionsWindow.
        /// </summary>
        public Bindable_Resources(IOptionsWindow_Get_Standard_Messages OptionsWindow)
        {
            Options_Text_FontSize = Set_Options_Text_FontSize();

            Set_Text(OptionsWindow.Get_Standard_Messages);

            ComboBox_List_Image_Height = Set_ComboBox_List_Image_Height();

            ComboBox_Element_Height = ComboBox_List_Image_Height + 12; // xyz

            ComboBox_Element_Width = Set_ComboBox_List_Image_Width();
        }
    }
}