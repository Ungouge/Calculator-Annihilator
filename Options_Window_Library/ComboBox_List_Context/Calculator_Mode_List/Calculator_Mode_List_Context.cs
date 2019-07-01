using System;
using System.Collections.Generic;
using Common_Library;

namespace Options_Window_Library
{
    internal partial class Calculator_Mode_List_Context : ComboBox_List_Context, ICalculator_Mode_List_Context
    {
        public List<ICalculator_Mode_List_Item> Calculator_Mode_Items_List { get; private set; }

        public ICalculator_Mode_List_Item Calculator_Mode_ComboBox_List_SelectedItem { get; set; }

        internal Calculator_Mode_List_Context(IStandard_Messages_Translate Standard_Messages, Calculator_Mode Calculator_Mode )
        {
            Calculator_Mode_Items_List = Set_Calculator_Mode_List_Items(Standard_Messages);

            Calculator_Mode_ComboBox_List_SelectedItem = Set_Current_Calculator_Mode_In_ComboBox(Calculator_Mode);
        }
    }
}
