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
        partial class Langauge_List_Context
        {
            private List<Langauge_List_Items> Set_Languge_List_Items()
            {
                List<Langauge_List_Items> Output_Items_List = new List<Langauge_List_Items>();

                foreach (Languages language in (Languages[]) Enum.GetValues(typeof(Languages)))
                {
                    Output_Items_List.Add( new Langauge_List_Items(Options_Window, language));
                }

                return Output_Items_List;
            }
        }
    }
}
