using System;

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        partial class Bindable_Resources
        {
            private MainWindow Current_Window;

            private Standard_Messages standard_Messages;

            /// <summary>
            /// Contains names of fields that should be recalculated at MainWindow state change
            /// </summary>
            static readonly private string[] Names_Of_properties_To_Handle = new string[]
            {
                "Button_FontSize", "WorkSpace_FontSize", "ResultSpace_FontSize", "Calculation_Type_Radio_Buttons_FontSize"
            };
        }
    }
}