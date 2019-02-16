﻿using System;
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
        partial class Bindable_Resources
        {
            private void Set_Font_Size_Texts(Standard_Messages standard_Messages)
            {
                foreach (Font_Size_List_Item list_Item in Font_Size_List_Items_List)
                {
                    list_Item.Font_Size_Name = standard_Messages.Translate(list_Item.Font_Size.ToString() + "_Font_Size");
                }

                On_Property_Change("Font_Size_List_Items_List");
            }
        }
    }
}