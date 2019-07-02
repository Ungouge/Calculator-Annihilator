using System;
using System.Windows;
using AnnihilatorWindowBase;
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
        public Bindable_Resources(  IOptions_Provider Options_Provider)
            : base(Options_Provider.Font_Size_Type, Options_Provider.Colour_Palette_Type)
        {
            Set_Elements_Sizes();

            ComboBox_List_Image_Size = Set_ComboBox_List_Image_Size();

            ComboBox_Element_Height = ComboBox_List_Image_Size + 12; // xyz

            ComboBox_Text_Width = ComboBox_Element_Width - ComboBox_List_Image_Size;

            TabItem_Margin_Thickness = new Thickness(Border_Thickness, Border_Thickness, Border_Thickness, 0);

            ComboBox_ToggleButton_Border_CornerRadius = new CornerRadius(Corner_Radius, 0, 0, Corner_Radius);

            ComboBox_ContentSite_Margin = new Thickness(Border_Thickness, Border_Thickness, Border_Thickness + ComboBox_ToggleButton_Arrow_Width, Border_Thickness);

            _Calculator_Mode_List_Context = new Calculator_Mode_List_Context(Options_Provider.Get_Standard_Messages_Translate, Options_Provider.Calculator_Mode);

            _Calculation_Method_List_Context = new Calculation_Method_List_Context(Options_Provider.Get_Standard_Messages_Translate, Options_Provider.Calculation_Method);

            _Comma_Type_List_Context = new Comma_Type_List_Context(Options_Provider.Get_Standard_Messages_Translate, Options_Provider);

            _Numeral_System_List_Context = new Numeral_System_List_Context(Options_Provider.Get_Standard_Messages_Translate, Options_Provider.Numeral_System_Code);

            _Number_Notation_List_Context = new Number_Notation_List_Context(Options_Provider.Get_Standard_Messages_Translate, Options_Provider.Number_Notation);

            _Langauge_List_Context = new Langauge_List_Context(Options_Provider.Get_Standard_Messages_Translate, Options_Provider.Current_Language);

            _Font_Size_List_Context = new Font_Size_List_Context(Options_Provider.Get_Standard_Messages_Translate, Options_Provider.Font_Size_Type);

            Set_Text(Options_Provider.Get_Standard_Messages_Translate);

            Set_Window_Size();
        }

    }
}