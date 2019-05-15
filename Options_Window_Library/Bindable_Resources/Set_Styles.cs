using System;
using System.Windows;
using AnnihilatorWindowBase;
using Common_Library;

namespace Options_Window_Library
{
    /// <summary>
    /// Provides data and properties for that can be binded in OptionsWindow.
    /// </summary>
    public partial class Bindable_Resources
    {
        public void Set_Styles()
        {
            Set_Element_Style_Delegate_Method("Button");

            //Set_Element_Style_Delegate_Method("DockPanel");

            //Set_Element_Style_Delegate_Method("Grid");

            //Set_Element_Style_Delegate_Method("TabControl");
        }
    }
}