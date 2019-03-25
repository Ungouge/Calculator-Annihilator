using System;

namespace Calculator_Annihilator_Library
{
    partial class Bindable_Resources
    {
        /// <summary>
        /// Pushes properties setted to be recalculated on call.
        /// </summary>
        public void Push_Recalculations()
        {
            On_Properties_Change(Names_Of_properties_To_Handle);
        }
    }
}
