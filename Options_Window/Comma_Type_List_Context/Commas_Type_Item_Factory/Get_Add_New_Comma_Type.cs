using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Options_Window
{
    partial class Commas_Type_Item_Factory
    {
        internal Add_New_Comma_Type_Control Get_Add_New_Comma_Type()
        {
            return new Add_New_Comma_Type_Control(OptionsWindow);
        }
    }
}
