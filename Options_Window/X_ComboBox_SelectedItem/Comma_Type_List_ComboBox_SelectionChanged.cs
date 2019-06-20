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
            if (Comma_Type_List_ComboBox.SelectedItem is Comma_Type_List_Content selected_Content)
            {
                Remove_Obsolete_Command<Change_Font_Size_Option_Command>();

                if (Comma_Type_List_ComboBox.SelectedItem is Item_Comma_Type_Control item_Control)
                {
                    string new_Comma_Type = item_Control.Content_Text;

                    Option_Change_Command_List.Add(new Change_Comma_Type_Option_Command(new_Comma_Type));
                }
                else if (Comma_Type_List_ComboBox.SelectedItem is Add_New_Comma_Type_Control)
                    Comma_Type_List_ComboBox.SelectedItem = _Bindable_Resources.Comma_Type_List_Context.Return_Current_Comma_Type_Item();
            }
        }
    }
}
