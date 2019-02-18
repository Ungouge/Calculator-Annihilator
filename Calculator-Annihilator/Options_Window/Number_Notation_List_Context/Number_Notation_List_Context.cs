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
        partial class Number_Notation_List_Context
        {
            private Options_Window Options_Window;

            public List<Number_Notation_List_Item> Number_Notation_List_Items_List { get; set; }

            public Number_Notation_List_Item Number_Notation_List_ComboBox_SelectedItem { get; set; }

            public Number_Notation_List_Context(Options_Window _Options_Window)
            {
                Options_Window = _Options_Window;

                Number_Notation_List_Items_List = Set_Number_Notation_List_Items();

                Number_Notation_List_ComboBox_SelectedItem =
                     Set_Current_Number_Notation_In_ComboBox(Options_Window.Options.Number_Notation);
            }
        }
    }
}
