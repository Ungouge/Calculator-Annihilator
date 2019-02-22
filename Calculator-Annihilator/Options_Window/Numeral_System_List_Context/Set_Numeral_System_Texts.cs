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
            internal void Set_Numeral_System_Texts(Standard_Messages standard_Messages)
            {
                foreach (Numeral_System_List_Item list_Item in Numeral_System_List_Items_List)
                {
                    string new_Numeral_System_Name = Numeral_System.Numeral_System_Dictionary_Name(
                        list_Item.numeral_System_Code, standard_Messages);

                    list_Item.Set_Numeral_System_Name(new_Numeral_System_Name);
                }
            }
        }
    }
}