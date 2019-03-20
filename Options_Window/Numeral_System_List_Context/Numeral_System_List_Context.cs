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

        private Numeral_System_Items_List _Numeral_System_List_Items_List { get; set; }

        public List<Numeral_System_List_Content> Numeral_System_List_Items_List
        {
            get
            {
                return _Numeral_System_List_Items_List.Get_Numeral_System_Items_List;
            }
        }

        public Numeral_System_List_Item Numeral_System_List_ComboBox_SelectedItem { get; set; }

        public Numeral_System_List_Context(OWXYZ _OptionsWindow)
        {
            OptionsWindow = _OptionsWindow;

            _Numeral_System_List_Items_List = new Numeral_System_Items_List(OptionsWindow);

            Numeral_System_List_ComboBox_SelectedItem =
                 Set_Numeral_System_List_ComboBox_SelectedItem(OptionsWindow.Options.Numeral_System_Code);
        }
    }
}
