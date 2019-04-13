using System;
using AnnihilatorWindowBase;
using Options_Library;
using IOptionsWindow_Parameters;
using Common_Library;

namespace Options_Window_Library
{
    /// <summary>
    /// Provides data and properties for that can be binded in OptionsWindow.
    /// </summary>
    public partial class Bindable_Resources: Annihilator_Window_Bindable_Resources_Base
    {
        /// <summary>
        /// Constructs new instance of Bindable_Resources for given OptionsWindow.
        /// </summary>
        public Bindable_Resources(IOptionsWindow_Get_Standard_Messages OptionsWindow, Font_Size_Type _Font_Size_Type) : base(_Font_Size_Type)
        {
            Set_Text(OptionsWindow.Get_Standard_Messages);

            ComboBox_List_Image_Height = Set_ComboBox_List_Image_Height();

            ComboBox_Element_Height = ComboBox_List_Image_Height + 12; // xyz

            ComboBox_Element_Width = Set_ComboBox_List_Image_Width();

            Set_Window_Size();
        }
        
    }
}