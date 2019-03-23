using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Options_Window_Library
{
    partial class Commas_Type_Item_Factory
    {
        internal Add_New_Comma_Type_Control Get_Add_New_Comma_Type(Comma_Type_List_Context Comma_Type_List_Context)
        {
            return new Add_New_Comma_Type_Control(Comma_Type_List_Context, Bindable_Resources, Standard_Messages);
        }
    }
}
