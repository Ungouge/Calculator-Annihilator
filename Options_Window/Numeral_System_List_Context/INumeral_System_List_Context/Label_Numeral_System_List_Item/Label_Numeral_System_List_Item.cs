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
        public partial class Label_Numeral_System_List_Item : INumeral_System_List_Context
        {
            public string Numeral_System_List_Item_Text { get; set; }

            public string Pin_Image_Uri { get; set; }

            public double Text_Width { get; set; }

            public double Image_Width { get; set; }

            public double Opacity { get; set; }

            internal Label_Numeral_System_List_Item(OWXYZ _OptionsWindow)
            {
                Image_Width = 0e0;

                Text_Width = _OptionsWindow._Bindable_Resources.ComboBox_Element_Width;

                Opacity = 0e0;

                Pin_Image_Uri = AppDomain.CurrentDomain.BaseDirectory + @"Library\Images\Pins\PinnedItem_64x_Transparent.png";
            }
        }
    }
}

//Numeral_System_List_Item_Text = _OptionsWindow.Options.Standard_Messages.Translate("XYZ");
