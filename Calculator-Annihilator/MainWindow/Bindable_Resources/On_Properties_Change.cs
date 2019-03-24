using System;

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        partial class Bindable_Resources
        {
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
}
