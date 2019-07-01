using System;
using Common_Library;

namespace Options_Window_Library
{
    /// <summary>
    /// Item with resources for Calculator_Mode_List_ComboBox.
    /// </summary>
    internal class Calculator_Mode_List_Item : ICalculator_Mode_List_Item
    {
        internal Calculator_Mode Calculator_Mode;

        public string Calculator_Mode_Name { get; set; }

        /// <summary>
        /// Constructs item for given Calculator_Mode.
        /// </summary>
        internal Calculator_Mode_List_Item(IStandard_Messages_Translate Standard_Messages, Calculator_Mode _Calculator_Mode)
        {
            Calculator_Mode = _Calculator_Mode;

            Calculator_Mode_Name = Standard_Messages.Translate(Calculator_Mode.ToString());
        }
    }
}
