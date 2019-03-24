using System;
using System.Windows.Controls;
using Common_Library;
using Options_Library;

namespace Options_Window
{
    partial class OWXYZ
    {
        private void Font_Size_List_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Remove_Obsolete_Command<Change_Font_Size_Option_Command>();

            Font_Size_Type New_Font = (Font_Size_Type)Font_Size_List_ComboBox.SelectedIndex;

            if (New_Font != Options.Font_Size_Type)
                Option_Change_Command_List.Add(new Change_Font_Size_Option_Command(New_Font));
        }
    }
}
