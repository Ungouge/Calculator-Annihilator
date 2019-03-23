using System;
using System.Windows;

namespace Options_Window_Library
{
    partial class Pinned_Item_Numeral_System_List_Control
    {
        internal override void Pin_Numeral_System_Click(object sender, RoutedEventArgs e)
        {
            Numeral_System_List_Context.Unpin_Numeral_System(this.Numeral_System_Code);
        }
    }
}
