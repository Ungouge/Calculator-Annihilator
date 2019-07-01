using System;
using Common_Library;

namespace Options_Window_Library
{
    /// <summary>
    /// Item with resources for Number_Notation_List_ComboBox.
    /// </summary>
    internal partial class Number_Notation_List_Item : INumber_Notation_List_Item
    {
        public string Number_Notation_Name { get; private set; }

        internal Number_Notation Number_Notation;

        /// <summary>
        /// Constructs item for given Number_Notation.
        /// </summary>
        internal Number_Notation_List_Item(IStandard_Messages_Translate Standard_Messages, Number_Notation _Number_Notation)
        {
            Number_Notation = _Number_Notation;

            Number_Notation_Name = Standard_Messages.Translate(Number_Notation.ToString() + "_Notation");
        }
    }
}
