using System;

namespace Calculator_Annihilator_Library
{
    partial class Bindable_Resources
    {
        /// <summary>
        /// Contains names of fields that should be recalculated at MainWindow state change
        /// </summary>
        static readonly private string[] Names_Of_properties_To_Handle = new string[]
        {
                "Button_FontSize", "WorkSpace_FontSize", "ResultSpace_FontSize", "Calculation_Type_Radio_Buttons_FontSize"
        };

        /// <summary>
        /// Pushes properties setted to be recalculated on call.
        /// </summary>
        private void On_Properties_Change(string[] properties_Names_Array)
        {
            foreach (string property_Name in properties_Names_Array)
            {
                On_Property_Change(property_Name);
            }
        }
    }
}
