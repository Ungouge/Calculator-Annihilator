using System;
using System.Windows;
using AnnihilatorWindowBase;
using Common_Library;

namespace Options_Window
{
    partial class OptionsWindow
    {
        protected override void Set_Styles()
        {
            Set_Element_Style("Button");

            Set_Element_Style("DockPanel");

            Set_Element_Style("Grid");

            Set_Element_Style("TabControl");

            Set_Element_Style("TabItem");

            Set_Element_Style("TextBlock");
        }
    }
}