using System;
using Common_Library;

namespace Options_Window_Library
{
    partial class Bindable_Resources
    {
        public string Options { get; set; }
        public string General_Options { get; set; }
        public string Calculator_Options { get; set; }

        private void Set_Tab_Item_Texts(IStandard_Messages_Translate standard_Messages)
        {
            Options= standard_Messages.Translate("Options");
            General_Options = standard_Messages.Translate("General_Options");
            Calculator_Options = standard_Messages.Translate("Calculator_Options");

            On_Properties_Change(new string[]
            {
                "Options",
                "General_Options",
                "Calculator_Options"
            });
        }
    }
}
