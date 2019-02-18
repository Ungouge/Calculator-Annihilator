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
            public partial class Number_Notation_List_Item
            {
                public string Number_Notation_Name { get; set; }

                internal Number_Notation Number_Notation;

                internal Number_Notation_List_Item(Options_Window _Options_Window, Number_Notation _Number_Notation)
                {
                    Number_Notation = _Number_Notation;

                    Number_Notation_Name = _Options_Window.Options.Standard_Messages.Translate(Number_Notation.ToString() + "_Notation");
                }

            }
        }
    }
}
