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
            private List<Langauge_List_Item> Set_Languges_List_Items()
            {
                List<Langauge_List_Item> Output_Items_List = new List<Langauge_List_Item>();

                foreach (Languages language in (Languages[]) Enum.GetValues(typeof(Languages)))
                {
                    Output_Items_List.Add( new Langauge_List_Item(Options_Window, language));
                }

                return Output_Items_List;
            }
        }
    }
}
