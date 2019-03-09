using System;
using System.Windows.Controls;
using Common_Library;
using Options_Library;

namespace Options_Window
{
    partial class OWXYZ
    {
        private void Number_Notation_List_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Remove_Obsolete_Command<Change_Number_Notation_Option_Command>();

            Number_Notation New_Number_Notation = (Number_Notation)Number_Notation_List_ComboBox.SelectedIndex;

            if (New_Number_Notation != Options.Number_Notation)
                Option_Change_Command_List.Add(new Change_Number_Notation_Option_Command(New_Number_Notation));

        }
    }
}
