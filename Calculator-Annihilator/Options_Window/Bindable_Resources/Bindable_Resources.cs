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
        public partial class Bindable_Resources
        {
            readonly Options_Window Options_Window;

            public double Language_List_ComboBox_Height { get; set; }

            public double ComboBox_List_Image_Height { get; set; }

            public List<Langauge_List_Item> Langauge_List_Items_List { get; set; }

            public Langauge_List_Item Language_List_ComboBox_SelectedItem { get; set; }

            public double Options_Text_FontSize { get; set; }

            public Bindable_Resources(Options_Window _Options_Window)
            {
                Options_Window = _Options_Window;

                Set_Text(Options_Window.Options.Standard_Messages);

                Options_Text_FontSize = Set_Options_Text_FontSize();

                Langauge_List_Items_List = Set_Languges_List_Items();

                Language_List_ComboBox_SelectedItem = 
                    Set_Current_Language_In_ComboBox(Options_Window.Options.Current_Language);

                ComboBox_List_Image_Height = Set_ComboBox_List_Image_Height()  ;

                Language_List_ComboBox_Height = ComboBox_List_Image_Height + 12 ;
            }
        }
    }
}
