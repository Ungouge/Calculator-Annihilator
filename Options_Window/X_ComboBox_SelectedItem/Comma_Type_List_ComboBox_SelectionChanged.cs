using System;
using System.Windows.Controls;
using Options_Library;
using Options_Window_Library;

namespace Options_Window
{
    partial class OptionsWindow
    {
        private void Comma_Type_List_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Comma_Type_List_ComboBox.SelectedItem is IComma_Type_List_Item selected_Item)
            {
                if (selected_Item.Is_Selectable == false)
                {
                    Comma_Type_List_ComboBox.SelectedItem = _Bindable_Resources.Comma_Type_List_Context.Return_Current_Comma_Type_Item();
                }
                else
                {
                    Remove_Obsolete_Command<Change_Font_Size_Option_Command>();

                    string new_Comma_Type = selected_Item.Content_Text;

                    Option_Change_Command_List.Add(new Change_Comma_Type_Option_Command(new_Comma_Type));
                } 
            }
        }
    }
}
