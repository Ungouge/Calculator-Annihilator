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
    partial class Numeral_System_List_Context
    {
        public partial class Label_Numeral_System_List_Item: INumeral_System_List_Content
        {
            public string Numeral_System_List_Content_Text { get; set; }

            public double Text_Width { get; set; }

            public UserControl Content_Control { get; set; }

            internal Label_Numeral_System_List_Item(OWXYZ _OptionsWindow)
            {
                Text_Width = _OptionsWindow._Bindable_Resources.ComboBox_Element_Width;

                Content_Control = new Label_Numeral_System_List_Control();
            }
        }
    }
}
