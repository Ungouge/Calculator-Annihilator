using System;
using System.Windows.Controls;
using Options_Library;

namespace Options_Window
{
    partial class OWXYZ
    {
        private void Numeral_System_List_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Remove_Obsolete_Command<Change_Numeral_System_Option_Command>();

            if (Numeral_System_List_ComboBox.SelectedItem is Numeral_System_List_Item List_Item)
            {
                sbyte New_Numeral_System = List_Item.Numeral_System_Code;

                if (New_Numeral_System != Options.Numeral_System_Code)
                    Option_Change_Command_List.Add(new Change_Numeral_System_Option_Command(New_Numeral_System));
            }
        }
    }
}
