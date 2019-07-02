using System;
using System.Windows.Controls;
using Common_Library;
using Options_Library;

namespace Options_Window
{
    partial class OptionsWindow
    {
        private void Calculation_Method_List_ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Remove_Obsolete_Command<Change_Calculation_Method_Option_Command>();

            Calculation_Method New_Calculation_Method = (Calculation_Method)Calculation_Method_List_ComboBox.SelectedIndex;

            if (New_Calculation_Method != Options_Provider.Calculation_Method)
                Option_Change_Command_List.Add(new Change_Calculation_Method_Option_Command(New_Calculation_Method));
        }
    }
}
