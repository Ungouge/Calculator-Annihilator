using System;
using System.Windows;
using AnnihilatorWindowBase;
using Common_Library;
using IOptionsWindow_Parameters;
using Options_Library;

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
        public Bindable_Resources(IGet_Standard_Messages _OptionsWindow, IOptionsWindow_For_Comma_Type_List_Context OptionsWindow_For_Comma_Type_List_Context,
            IOptions_Provider Options_Provider) : base(Options_Provider.Font_Size_Type, Options_Provider.Colour_Palette_Type)
        {
            Set_Elements_Sizes();

            ComboBox_List_Image_Size = Set_ComboBox_List_Image_Size();

            ComboBox_Element_Height = ComboBox_List_Image_Size + 12; // xyz

            TabItem_Margin_Thickness = new Thickness(Border_Thickness, Border_Thickness, Border_Thickness, 0);

            ComboBox_ToggleButton_Border_CornerRadius = new CornerRadius(Corner_Radius, 0, 0, Corner_Radius);

            ComboBox_ContentSite_Margin = new Thickness(Border_Thickness, Border_Thickness, Border_Thickness + ComboBox_ToggleButton_Arrow_Width, Border_Thickness);

            Comma_Type_List_Context = new Comma_Type_List_Context(this, OptionsWindow_For_Comma_Type_List_Context);

            Numeral_System_List_Context = new Numeral_System_List_Context(Options_Provider.Get_Standard_Messages_Translate, Options_Provider.Numeral_System_Code);

            Number_Notation_List_Context = new Number_Notation_List_Context(Options_Provider.Get_Standard_Messages_Translate, Options_Provider.Number_Notation);

            Langauge_List_Context = new Langauge_List_Context(Options_Provider.Get_Standard_Messages_Translate, Options_Provider.Current_Language);

            Font_Size_List_Context = new Font_Size_List_Context(Options_Provider.Get_Standard_Messages_Translate, Options_Provider.Font_Size_Type);

            Set_Text(_OptionsWindow.Get_Standard_Messages);

            Set_Window_Size();
        }

    }
}