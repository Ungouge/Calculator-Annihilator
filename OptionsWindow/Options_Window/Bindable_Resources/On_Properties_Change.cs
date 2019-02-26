using System;
using System.ComponentModel;

namespace OptionsWindow
{
    partial class Options_Window
    {
        partial class Bindable_Resources
        {
            private void On_Properties_Change(string[] properties_Names_Array)
            {
                foreach (string property_Name in properties_Names_Array)
                {
                    On_Property_Change(property_Name);
                }
            }
        }
    }
}