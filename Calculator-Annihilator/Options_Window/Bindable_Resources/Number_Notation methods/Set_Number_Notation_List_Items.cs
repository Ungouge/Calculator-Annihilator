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
        public partial class Bindable_Resources
        {
            private List<Number_Notation_List_Item> Set_Number_Notation_List_Items()
            {
                List<Number_Notation_List_Item> Output_Items_List = new List<Number_Notation_List_Item>();

                foreach (Number_Notation number_Notation in (Number_Notation[])Enum.GetValues(typeof(Number_Notation)))
                {
                    Output_Items_List.Add(new Number_Notation_List_Item(Options_Window, number_Notation));
                }

                return Output_Items_List;
            }
        }
    }
}
