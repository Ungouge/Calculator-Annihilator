using System.Collections.Generic;

namespace Options_Window_Library
{
    public interface ICalculator_Mode_List_Context
    {
        List<ICalculator_Mode_List_Item> Calculator_Mode_Items_List { get; }

        ICalculator_Mode_List_Item Calculator_Mode_ComboBox_List_SelectedItem { get; set; }
    }
}