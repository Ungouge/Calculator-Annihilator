using System;
using Common_Library;

namespace Options_Window
{
    partial class OptionsWindow
    {
        protected override void Set_Element_Style(string element_Name)
        {
            element_Name += "_Style";

            string resource_Name;

            if (Options.Colour_Palette_Type == Colour_Palette_Type.Defalut)
                resource_Name = "Default_" + element_Name;
            else
                resource_Name = "Base_" + element_Name;

            Resources[element_Name] = Resources[resource_Name];
        }
    }
}
