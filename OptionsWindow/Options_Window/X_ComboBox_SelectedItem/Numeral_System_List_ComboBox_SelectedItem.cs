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
        private void Numeral_System_List_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Remove_Obsolete_Command<Change_Numeral_System_Option_Command>();

            short new_Numeral_System_ComboBox_Item_Index  = (short)Numeral_System_List_ComboBox.SelectedIndex;

            sbyte New_Numeral_System = _Numeral_System_List_Context.
                Numeral_System_List_Items_List[new_Numeral_System_ComboBox_Item_Index].numeral_System_Code;

            if (New_Numeral_System != Options.Numeral_System_Code)
                Option_Change_Command_List.Add(new Change_Numeral_System_Option_Command(New_Numeral_System));
        }
    }
}
