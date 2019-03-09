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

            short new_Numeral_System_ComboBox_Item_Index  = (short)Numeral_System_List_ComboBox.SelectedIndex;

            if (sender is INumeral_System_List_Item _Item)
            {
                sbyte New_Numeral_System = _Item.Numeral_System_Code;

                if (New_Numeral_System != Options.Numeral_System_Code)
                    Option_Change_Command_List.Add(new Change_Numeral_System_Option_Command(New_Numeral_System));
            }
        }
    }
}
