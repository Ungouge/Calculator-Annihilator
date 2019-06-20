using System;

namespace AnnihilatorWindowBase
{
    partial class Annihilator_Window_Base 
    {
        protected readonly string[] Styled_Elements_List  = new string[] { "Button", "ComboBox", "DockPanel", "Grid", "Highlightable_TextBlock", "TabControl", "TabItem", "TextBlock" };

        protected void Set_Styles()
        {
            //XYZ
            //if (Options_Provider.Colour_Palette_Type == Colour_Palette_Type.Defalut && Options_Provider.Font_Size_Type != Font_Size_Type.Hight_Contrast)
            //    Set_Element_Base_Style();
            //else
            Set_Element_Default_Style();
        }

        protected void Set_Element_Base_Style()
        {
            foreach (string element in Styled_Elements_List)
            {
                string element_Name = element + "_Style";

                string resource_Name = "Base_" + element_Name;

                Resources[element_Name] = Resources[resource_Name];
            }
        }

        protected void Set_Element_Default_Style()
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
