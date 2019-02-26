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

namespace Options_Window
{
    partial class OWXYZ
    {
        partial class Number_Notation_List_Context
        {
            private OWXYZ OptionsWindow;

            public List<Number_Notation_List_Item> Number_Notation_List_Items_List { get; set; }

            public Number_Notation_List_Item Number_Notation_List_ComboBox_SelectedItem { get; set; }

            public Number_Notation_List_Context(OWXYZ _OptionsWindow)
            {
                OptionsWindow = _OptionsWindow;

                Number_Notation_List_Items_List = Set_Number_Notation_List_Items();

                Number_Notation_List_ComboBox_SelectedItem =
                     Set_Current_Number_Notation_In_ComboBox(OptionsWindow.Options.Number_Notation);
            }
        }
    }
}
