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
    internal partial class Numeral_System_List_Context
    {
        private OWXYZ OptionsWindow;

        public List<INumeral_System_List_Content> Numeral_System_List_Items_List { get; set; }

        public Numeral_System_List_Item Numeral_System_List_ComboBox_SelectedItem { get; set; }

        public Numeral_System_List_Context(OWXYZ _OptionsWindow)
        {
            OptionsWindow = _OptionsWindow;

            Numeral_System_List_Items_List = Set_Numeral_System_List_Items();

            Numeral_System_List_ComboBox_SelectedItem =
                 Set_Current_Numeral_System_In_ComboBox(OptionsWindow.Options.Numeral_System_Code);
        }
    }
}
