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
    public partial class Options_Window : Window
    {
        public partial class Bindable_Resources
        {
            readonly Options_Window Options_Window;

            public double Language_List_ComboBox_Height { get; set; }

            public List<Langauge_List_Item> Langauge_List_Items_List { get; set; }

            public Langauge_List_Item Language_List_ComboBox_SelectedItem { get; set; }

            public Bindable_Resources(Options_Window _Options_Window)
            {
                Options_Window = _Options_Window;

                Langauge_List_Items_List = Set_Languges_List_Items();

                Langauge_List_Item Language_List_ComboBox_SelectedItem = 
                    Set_Current_Language_In_ComboBox(Options_Window.Paretnt_MainWindow.Current_Language);

                Language_List_ComboBox_Height = Set_Language_List_ComboBox_Height();

                Set_Text_Bindables();
            }
        }
    }
}
