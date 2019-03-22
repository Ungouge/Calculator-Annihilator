using System;
using Common_Library;
using IOptions_Window;

namespace Options_Window
{
    partial class Number_Notation_List_Context
    {
        public partial class Number_Notation_List_Item
        {
            public string Number_Notation_Name { get; set; }

            internal Number_Notation Number_Notation;

            internal Number_Notation_List_Item(IOptionsWindow_Parameters _OptionsWindow, Number_Notation _Number_Notation)
            {
                Number_Notation = _Number_Notation;

                Number_Notation_Name = _OptionsWindow.Get_Standard_Messages.Translate(Number_Notation.ToString() + "_Notation");
            }

        }
    }
}
