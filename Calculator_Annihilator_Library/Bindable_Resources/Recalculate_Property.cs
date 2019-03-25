using System;

namespace Calculator_Annihilator_Library
{
    partial class Bindable_Resources
    {
        /// <summary>
        /// Recalculates property of given Name
        /// </summary>
        public void Recalculate_Property (string Property_Name)
        {
           On_Property_Change(Property_Name);
        }
    }
}
