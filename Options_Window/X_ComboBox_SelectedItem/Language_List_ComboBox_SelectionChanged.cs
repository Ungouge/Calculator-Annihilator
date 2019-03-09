using System;
using System.Windows.Controls;
using Common_Library;
using Options_Library;

namespace Options_Window
{
    partial class OWXYZ
    {
        private void Language_List_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Remove_Obsolete_Command<Change_Language_Option_Command>();

            Languages New_Language = (Languages)Language_List_ComboBox.SelectedIndex;

            if (New_Language != Options.Current_Language)
                Option_Change_Command_List.Add(new Change_Language_Option_Command(New_Language));
        }
    }
}
