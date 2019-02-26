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
    partial class Number_Notation_List_Context
    {
        partial class Number_Notation_List_Item
        {
            internal void Number_Notation_Size_Name(string new_Number_Notation_Name)
            {
                Number_Notation_Name = new_Number_Notation_Name;
                On_Property_Change("Number_Notation_Name");
            }
        }
    }
}
