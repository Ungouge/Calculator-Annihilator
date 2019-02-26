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

namespace OptionsWindow
{
    partial class Options_Window
    {
        partial class Numeral_System_List_Context
        {
            public partial class Pined_Numeral_System_List_Item : Numeral_System_List_Item
            {
                internal Pined_Numeral_System_List_Item(Options_Window _Options_Window, sbyte _numeral_System_Code)
                    :base(_numeral_System_Code, _Options_Window)
                {
                    Pin_Image_Uri = AppDomain.CurrentDomain.BaseDirectory + @"Library\Images\Pins\PinnedItem_64x_Pined.png";
                }
            }
        }
    }
}
