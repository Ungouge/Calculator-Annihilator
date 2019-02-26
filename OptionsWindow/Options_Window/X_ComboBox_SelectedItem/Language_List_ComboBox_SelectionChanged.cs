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

namespace OptionsWindow
{
    partial class Options_Window
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
