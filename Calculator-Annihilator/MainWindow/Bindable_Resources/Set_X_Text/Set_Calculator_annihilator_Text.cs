using System;

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        partial class Bindable_Resources
        {
            public string Title { get; set; }
            public string Single_Calculations { get; set; }
            public string Complex_Calculations { get; set; }

            private void Set_Calculator_annihilator_Text()
            {
                // \Calculator_Annihilator.xml

                Title = standard_Messages.Translate("Title");
                Single_Calculations = standard_Messages.Translate("Single_Calculations");
                Complex_Calculations = standard_Messages.Translate("Complex_Calculations");
            }
        }
    }
}
