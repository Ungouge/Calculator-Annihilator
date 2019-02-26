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
        partial class Langauge_List_Context
        {
            public class Langauge_List_Items
            {
                private Options_Window Options_Window;

                public string Language_Name { get; set; }

                public string Language_Flag_Uri { get; set; }

                internal Languages Language;

                internal Langauge_List_Items(Options_Window _Options_Window, Languages _Language)
                {
                    Language = _Language;

                    Language_Name = _Options_Window.Options.Standard_Messages.Translate( Language.ToString() + "_Native" );

                    Language_Flag_Uri = AppDomain.CurrentDomain.BaseDirectory + @"Library\Images\Language_Flags\" + Language.ToString() + "_Flag.png";
                }
            }
        }
    }
}
