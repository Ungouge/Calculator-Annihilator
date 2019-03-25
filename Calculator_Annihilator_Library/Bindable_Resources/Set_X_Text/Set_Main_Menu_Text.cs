using System;
using Common_Library;

namespace Calculator_Annihilator_Library
{
    partial class Bindable_Resources
    {
        public string File { get; set; }
        public string View { get; set; }
        public string Edit { get; set; }
        public string Help { get; set; }
        public string New_Window { get; set; }
        public string Options { get; set; }
        public string Close_Window { get; set; }
        public string Standard { get; set; }
        public string Scientific { get; set; }

        private void Set_Main_Menu_Text(IStandard_Messages_Translate standard_Messages)
        {
            // \Main_Menu.xml

            File = standard_Messages.Translate("File");
            View = standard_Messages.Translate("View");
            Edit = standard_Messages.Translate("Edit");
            Help = standard_Messages.Translate("Help");
            New_Window = standard_Messages.Translate("New_Window");
            Options = standard_Messages.Translate("Options");
            Close_Window = standard_Messages.Translate("Close_Window");
            Standard = standard_Messages.Translate("Standard");
            Scientific = standard_Messages.Translate("Scientific");

            On_Properties_Change(new string[] {
                    "File",
                    "View",
                    "Edit",
                    "Help",
                    "New_Window",
                    "Options",
                    "Close_Window",
                    "Standard",
                    "Scientific"
                });
        }
    }
}
