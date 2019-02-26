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
        partial class Langauge_List_Context
        {
            private OWXYZ OptionsWindow;

            public List<Langauge_List_Items> Langauge_List_Items_List { get; set; }

            public Langauge_List_Items Language_List_ComboBox_SelectedItem { get; set; }

            public Langauge_List_Context(OWXYZ _OptionsWindow)
            {
                OptionsWindow = _OptionsWindow;

                Langauge_List_Items_List = Set_Languge_List_Items();

                Language_List_ComboBox_SelectedItem =
                     Set_Current_Language_In_ComboBox(OptionsWindow.Options.Current_Language);
            }
        }
    }
}
