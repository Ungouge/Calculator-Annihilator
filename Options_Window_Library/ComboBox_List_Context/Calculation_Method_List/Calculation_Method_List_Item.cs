using System;
using Common_Library;

namespace Options_Window_Library
{
    /// <summary>
    /// Item with resources for Calculation_Method_List_ComboBox.
    /// </summary>
    internal class Calculation_Method_List_Item : ICalculation_Method_List_Item
    {
        internal Calculation_Method Calculation_Method;

        public string Calculation_Method_Name { get; set; }

        /// <summary>
        /// Constructs item for given Calculation_Method.
        /// </summary>
        internal Calculation_Method_List_Item(IStandard_Messages_Translate Standard_Messages, Calculation_Method _Calculation_Method)
        {
            Calculation_Method = _Calculation_Method;

            Calculation_Method_Name = Standard_Messages.Translate(Calculation_Method.ToString());
        }
    }
}
