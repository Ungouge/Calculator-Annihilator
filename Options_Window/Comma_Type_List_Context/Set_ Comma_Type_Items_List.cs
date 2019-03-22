
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Options_Window
{
    partial class Comma_Type_List_Context
    {
        private List<Comma_Type_List_Content> Set_Comma_Type_Items_List()
        {
            List<Comma_Type_List_Content> Output_List = new List<Comma_Type_List_Content>();

            foreach (string comma_Type in Commas_Type)
            {
                Output_List.Add(Factory.Get_Item(comma_Type));
            }

            Output_List.Add(Factory.Get_Add_New_Comma_Type());

            return Output_List;
        }
    }
}
