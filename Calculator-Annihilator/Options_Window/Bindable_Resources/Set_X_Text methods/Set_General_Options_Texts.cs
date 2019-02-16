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
        partial class Bindable_Resources
        {
            public string Language { get; set; }
            public string Font_Size_Type { get; set; }

            private void Set_General_Options_Texts(Standard_Messages standard_Messages)
            {
                Language = standard_Messages.Translate("Language");
                Font_Size_Type = standard_Messages.Translate("Font_Size_Type");

                On_Properties_Change(new string[]
                {
                    "Language",
                    "Font_Size_Type"
                });
            }
        }
    }
}