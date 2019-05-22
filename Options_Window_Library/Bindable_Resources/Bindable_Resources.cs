using System;
using AnnihilatorWindowBase;
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
        public Bindable_Resources(IGet_Standard_Messages _OptionsWindow, Set_Element_Style_Delegate _Set_Element_Style_Delegate_Method, Font_Size_Type _Font_Size_Type, Colour_Palette_Type _Colour_Palette_Type) : base(_Font_Size_Type, _Colour_Palette_Type )
        {
            Set_Element_Style_Delegate_Method = _Set_Element_Style_Delegate_Method;

            Set_Text(_OptionsWindow.Get_Standard_Messages);

            ComboBox_List_Image_Height = Set_ComboBox_List_Image_Height();

            ComboBox_Element_Height = ComboBox_List_Image_Height + 12; // xyz

            ComboBox_Element_Width = Set_ComboBox_List_Image_Width();

            Set_Window_Size();
        }
    }
}