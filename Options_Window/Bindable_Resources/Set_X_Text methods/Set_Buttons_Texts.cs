using System;
using Common_Library;


namespace Options_Window
{
    partial class OWXYZ
    {
        partial class Bindable_Resources
        {
            public string Apply_All_Windows { get; set; }
            public string Ok { get; set; }
            public string Cancel { get; set; }
            public string Apply { get; set; }

            private void Set_Buttons_Texts(Standard_Messages standard_Messages)
            {
                Apply_All_Windows = standard_Messages.Translate("Apply_All_Windows");
                Ok = standard_Messages.Translate("Ok");
                Cancel = standard_Messages.Translate("Cancel");
                Apply = standard_Messages.Translate("Apply");

                On_Properties_Change(new string[]
                {
                    "Apply_All_Windows",
                    "Ok",
                    "Cancel",
                    "Apply"
                });
            }
        }
    }
}
