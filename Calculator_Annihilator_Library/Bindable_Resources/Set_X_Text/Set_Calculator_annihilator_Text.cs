using System;
using Common_Library;

namespace Calculator_Annihilator_Library
{
    partial class Bindable_Resources
    {
        public string Title { get; set; }
        public string Single_Calculations { get; set; }
        public string Complex_Calculations { get; set; }

        private void Set_Calculator_annihilator_Text(IStandard_Messages_Translate standard_Messages)
        {
            // \Calculator_Annihilator.xml

            Title = standard_Messages.Translate("Title");
            Single_Calculations = standard_Messages.Translate("Single_Calculations");
            Complex_Calculations = standard_Messages.Translate("Complex_Calculations");

            On_Properties_Change(new string[] {
                "Title",
                "Single_Calculations",
                "Complex_Calculations"
            });
        }
    }
}
