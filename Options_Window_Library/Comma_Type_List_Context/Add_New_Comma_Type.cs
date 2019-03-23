using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Options_Window_Library
{
    partial class Comma_Type_List_Context
    {
        internal void Add_New_Comma_Type(string new_Comma)
        {
            Commas_Type = Commas_Type.Concat(new string[] { new_Comma }).ToArray();

            Comma_Type_Items_List = Set_Comma_Type_Items_List();

            OptionsWindow.Add_New_Comma_Type_Option_Command(Commas_Type);

            On_Property_Change("Comma_Type_Items_List");
        }
    }
}
