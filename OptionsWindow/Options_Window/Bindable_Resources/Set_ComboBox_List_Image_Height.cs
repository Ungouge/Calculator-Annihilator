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

namespace OptionsWindow
{
    partial class Options_Window
    {
        public partial class Bindable_Resources
        {
            public double Set_ComboBox_List_Image_Height()
            {
                Formatted_Text_Getter formatted_Text =
                    new Formatted_Text_Getter(new TextBlock() { Text = "Xyz" },
                    Options_Text_FontSize);

                return formatted_Text.Get_Text_Height;
            }
        }
    }
}
