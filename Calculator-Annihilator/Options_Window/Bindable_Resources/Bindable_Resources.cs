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

            public double Language_List_ComboBox_Item_Height { get; set; }

            object Language_List_ComboBox_SelectedItem;

            public Bindable_Resources(Options_Window _Options_Window)
            {
                Options_Window = _Options_Window;
                Set_Language_List_Bidables();

                //Formatted_Text_Getter formatted_Text = new Formatted_Text_Getter(_Options_Window.English_Language_List_ComboBox_Item, _Options_Window.English_Language_List_ComboBox_Item.FontSize);

                Language_List_ComboBox_Item_Height = 3e1;// formatted_Text.Get_Text_Height;
            }
        }
    }
}
