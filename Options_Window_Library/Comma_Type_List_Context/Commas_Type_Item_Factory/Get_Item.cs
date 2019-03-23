using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Options_Window_Library
{
    partial class Commas_Type_Item_Factory
    {
        internal Item_Comma_Type_Control Get_Item(string comma)
        {
            return new Item_Comma_Type_Control(Bindable_Resources, comma);
        }
    }
}
