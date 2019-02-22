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
            public partial class Numeral_System_List_Item
            {
                public string Numeral_System_Name { get; set; }

                internal sbyte numeral_System_Code;

                internal Numeral_System_List_Item(Options_Window _Options_Window, sbyte _numeral_System_Code)
                {
                    numeral_System_Code = _numeral_System_Code;

                    Numeral_System_Name = Numeral_System.Numeral_System_Dictionary_Name(
                        numeral_System_Code, _Options_Window.Options.Standard_Messages);
                }

            }
        }
    }
}
