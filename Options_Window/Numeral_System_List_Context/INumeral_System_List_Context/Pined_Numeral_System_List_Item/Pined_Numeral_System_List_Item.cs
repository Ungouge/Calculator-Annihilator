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
        partial class Numeral_System_List_Context
        {
            public partial class Pined_Numeral_System_List_Item : Numeral_System_List_Item
            {
                internal Pined_Numeral_System_List_Item(OWXYZ _OptionsWindow, sbyte _numeral_System_Code)
                    :base(_numeral_System_Code, _OptionsWindow)
                {
                    Pin_Image_Uri = AppDomain.CurrentDomain.BaseDirectory + @"Library\Images\Pins\PinnedItem_64x_Pined.png";
                }
            }
        }
    }
}
