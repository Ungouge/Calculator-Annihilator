using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Calculator_Annihilator
{
    partial class Options_Window
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
