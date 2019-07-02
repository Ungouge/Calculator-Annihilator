using System;
using System.Collections.Generic;
using Common_Library;

namespace Options_Window_Library
{
    internal partial class Calculation_Method_List_Context : ComboBox_List_Context, ICalculation_Method_List_Context
    {
        public List<ICalculation_Method_List_Item> Calculation_Method_Items_List { get; private set; }

        public ICalculation_Method_List_Item Calculation_Method_ComboBox_List_SelectedItem { get; set; }

        internal Calculation_Method_List_Context(IStandard_Messages_Translate Standard_Messages, Calculation_Method Calculation_Method )
        {
            Calculation_Method_Items_List = Set_Calculation_Method_List_Items(Standard_Messages);

            Calculation_Method_ComboBox_List_SelectedItem = Set_Current_Calculation_Method_In_ComboBox(Calculation_Method);
        }
    }
}
