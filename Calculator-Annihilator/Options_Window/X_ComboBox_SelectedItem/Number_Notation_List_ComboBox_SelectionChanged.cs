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
        private void Number_Notation_List_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Remove_Obsolete_Command<Change_Number_Notation_Option_Command>();

            Number_Notation New_Number_Notation = (Number_Notation)Number_Notation_List_ComboBox.SelectedIndex;

            if (New_Number_Notation != Options.Number_Notation)
                Option_Change_Command_List.Add(new Change_Number_Notation_Option_Command(New_Number_Notation));

        }
    }
}
