using System;

namespace OptionsWindow
{
    partial class Options_Window
    {
        partial class Bindable_Resources
        {
            public string Number_Notation_Type { get; set; }
            public string Numeral_System_Type { get; set; }
            public string Comma_Symbol { get; set; }
            public string Mode_Calculator { get; set; }
            public string Method_Calculation { get; set; }

            private void Set_Calculator_Options_Text(Standard_Messages standard_Messages)
            {
                Number_Notation_Type = standard_Messages.Translate("Number_Notation_Type");
                Numeral_System_Type = standard_Messages.Translate("Numeral_System_Type");
                Comma_Symbol = standard_Messages.Translate("Comma_Symbol");
                Mode_Calculator = standard_Messages.Translate("Mode_Calculator");
                Method_Calculation = standard_Messages.Translate("Method_Calculation");

                On_Properties_Change(new string[]
                {
                    "Number_Notation_Type",
                    "Numeral_System_Type",
                    "Comma_Symbol",
                    "Mode_Calculator",
                    "Method_Calculation"
                });
            }
        }
    }
}