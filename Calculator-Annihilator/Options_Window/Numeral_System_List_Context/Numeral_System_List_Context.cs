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
        public partial class Numeral_System_List_Context
        {
            private Options_Window Options_Window;

            public List<Numeral_System_List_Item> Numeral_System_List_Items_List { get; set; }

            public Numeral_System_List_Item Numeral_System_List_ComboBox_SelectedItem { get; set; }

            public Numeral_System_List_Context(Options_Window _Options_Window)
            {
                Options_Window = _Options_Window;

                Numeral_System_List_Items_List = Set_Numeral_System_List_Items();

                Numeral_System_List_ComboBox_SelectedItem =
                     Set_Current_Numeral_System_In_ComboBox(Options_Window.Options.Numeral_System_Code);
            }
        }
    }
}
