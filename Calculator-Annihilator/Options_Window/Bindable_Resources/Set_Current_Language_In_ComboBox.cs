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
    public partial class Options_Window : Window
    {
        partial class Bindable_Resources
        {
            private Langauge_List_Item Set_Current_Language_In_ComboBox(Languages current_Language)
            {
                foreach (Langauge_List_Item item in Langauge_List_Items_List)
                {
                    if (item.Language == current_Language)
                        return item;
                }

                return null;
            }
        }
    }
}
