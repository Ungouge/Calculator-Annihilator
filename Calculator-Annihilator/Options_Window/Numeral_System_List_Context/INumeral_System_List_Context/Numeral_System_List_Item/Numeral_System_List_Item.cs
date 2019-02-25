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
        partial class Numeral_System_List_Context
        {
            public partial class Numeral_System_List_Item: INumeral_System_List_Context
            {
                public string Numeral_System_List_Item_Text { get; set; }

                internal sbyte numeral_System_Code;

                public string Pin_Image_Uri { get; set; }

                public double Text_Width { get; set; }

                public double Image_Width { get; set; }

                public double Opacity { get; set; }

                internal Numeral_System_List_Item(Options_Window _Options_Window, sbyte _numeral_System_Code)
                    :this (_numeral_System_Code, _Options_Window)
                {
                    Pin_Image_Uri = AppDomain.CurrentDomain.BaseDirectory + @"Library\Images\Pins\PinnedItem_64x_Clear.png";
                }

                protected Numeral_System_List_Item(sbyte _numeral_System_Code, Options_Window _Options_Window)
                {
                    numeral_System_Code = _numeral_System_Code;

                    Numeral_System_List_Item_Text = Numeral_System.Numeral_System_Dictionary_Name(
                        numeral_System_Code, _Options_Window.Options.Standard_Messages);

                    Image_Width = _Options_Window._Bindable_Resources.ComboBox_List_Image_Height;

                    Text_Width = _Options_Window._Bindable_Resources.ComboBox_Element_Width - Image_Width;

                    Opacity = 0e0;
                }

            }
        }
    }
}
