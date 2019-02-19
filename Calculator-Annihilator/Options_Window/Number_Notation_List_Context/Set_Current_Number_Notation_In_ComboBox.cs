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
            private Number_Notation_List_Item Set_Current_Number_Notation_In_ComboBox(Number_Notation current_Number_Notation)
            {
                foreach (Number_Notation_List_Item item in Number_Notation_List_Items_List)
                {
                    if (item.Number_Notation == current_Number_Notation)
                        return item;
                }
                Number_Notation_List_ComboBox.se
                return null;
            }
        }
    }
}

