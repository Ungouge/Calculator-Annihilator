using System;
using System.Windows.Controls;
using Common_Library;
using Options_Library;

namespace Options_Window
{
    partial class OptionsWindow
    {
        private void Calculator_Mode_List_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Remove_Obsolete_Command<Change_Calculator_Mode_Option_Command>();

            Calculator_Mode New_Calculator_Mode = (Calculator_Mode)Calculator_Mode_List_ComboBox.SelectedIndex;

            if (New_Calculator_Mode != Options_Provider.Calculator_Mode)
                Option_Change_Command_List.Add(new Change_Calculator_Mode_Option_Command(New_Calculator_Mode));
        }
    }
}
