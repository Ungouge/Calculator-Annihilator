using System.Collections.Generic;

namespace Options_Window_Library
{
    public interface ICalculation_Method_List_Context
    {
        List<ICalculation_Method_List_Item> Calculation_Method_Items_List { get; }

        ICalculation_Method_List_Item Calculation_Method_ComboBox_List_SelectedItem { get; set; }
    }
}