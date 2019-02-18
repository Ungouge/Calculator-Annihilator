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
        partial class Number_Notation_List_Context
        {
            internal void Set_Number_Notation_Texts(Standard_Messages standard_Messages)
            {
                foreach (Number_Notation_List_Item list_Item in Number_Notation_List_Items_List)
                {
                    list_Item.Number_Notation_Size_Name(
                        standard_Messages.Translate(list_Item.Number_Notation.ToString() + "_Notation"));
                }
            }
        }
    }
}