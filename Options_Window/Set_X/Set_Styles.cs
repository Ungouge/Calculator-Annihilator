using System;
using System.Windows;
using AnnihilatorWindowBase;
using Common_Library;

namespace Options_Window
{
    partial class OptionsWindow
    {
        protected override string[] Styled_Elements_List { get; } = new string[] { "Button", "DockPanel", "Grid", "TabControl", "TabItem", "TextBlock" };

        protected override void Set_Styles()
        {
            if ( Options.Colour_Palette_Type == Colour_Palette_Type.Defalut && Options.Font_Size_Type != Font_Size_Type.Hight_Contrast)
                Set_Element_Base_Style();
            else
                Set_Element_Default_Style();
        }

        protected override void Set_Element_Base_Style()
        {
            foreach (string element in Styled_Elements_List)
            {
                string element_Name = element + "_Style";

                string resource_Name = "Base_" + element_Name;

                Resources[element_Name] = Resources[resource_Name];
            }
        }

        protected override void Set_Element_Default_Style()
        {
            foreach (string element in Styled_Elements_List)
            {
                string element_Name = element + "_Style";

                string resource_Name = "Default_" + element_Name;

                Resources[element_Name] = Resources[resource_Name];
            }
        }
    }
}