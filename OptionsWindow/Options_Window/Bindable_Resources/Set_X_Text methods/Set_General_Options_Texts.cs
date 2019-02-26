using System;

namespace OptionsWindow
{
    partial class Options_Window
    {
        partial class Bindable_Resources
        {
            public string Language { get; set; }
            public string Font_Size_Type { get; set; }

            private void Set_General_Options_Texts(Standard_Messages standard_Messages)
            {
                Language = standard_Messages.Translate("Language");
                Font_Size_Type = standard_Messages.Translate("Font_Size_Type");

                On_Properties_Change(new string[]
                {
                    "Language",
                    "Font_Size_Type"
                });
            }
        }
    }
}