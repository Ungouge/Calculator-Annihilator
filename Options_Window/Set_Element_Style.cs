using System;
using System.Windows;
using System.Collections.Generic;
using Common_Library;
using Options_Library;
using IOptionsWindow_Parameters;
using Windows_Structure;
using Options_Window_Library;
using AnnihilatorWindowBase;

namespace Options_Window
{
    partial class OptionsWindow
    {

        public void Set_Element_Style(string element_Name)
        {
            element_Name += "_Style";

            string resource_Name;

            if (Options.Font_Size_Type == Font_Size_Type.Hight_Contrast)
                resource_Name = "Default_" + element_Name;
            else
                resource_Name = "Base_" + element_Name;

            Resources[element_Name] = Resources[resource_Name];
        }
    }
}
