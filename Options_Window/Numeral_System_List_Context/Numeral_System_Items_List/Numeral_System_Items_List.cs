
using Common_Library;
using Options_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Options_Window
{
    partial class Numeral_System_List_Context
    {
        internal partial class Numeral_System_Items_List
        {
            OWXYZ OptionsWindow;

            List<Numeral_System_List_Item> Items_List;

            List<Numeral_System_List_Item> Pinned_Items_List;

            Numeral_System_List_Content_Factory Factory;
            
            public Numeral_System_Items_List(OWXYZ _OptionsWindow)
            {
                OptionsWindow = _OptionsWindow;

                Factory = new Numeral_System_List_Content_Factory(OptionsWindow);

                if (Pinned_Numeral_Systems.Get_Numeral_Systems_Codes.Length > 0)
                    Pinned_Items_List = Set_Pinned_Numeral_System_List();
                else
                    Pinned_Items_List = new List<Numeral_System_List_Item>();

                Items_List = Set_Numeral_System_List();
            }

            private List<Numeral_System_List_Item> Set_Pinned_Numeral_System_List()
            {
                List<Numeral_System_List_Item> Output_Items_List = new List<Numeral_System_List_Item>();

                foreach (sbyte numeral_System in Pinned_Numeral_Systems.Get_Numeral_Systems_Codes)
                {
                    Output_Items_List.Add(Factory.Get_Item(numeral_System));
                }

                return Output_Items_List;
            }

            private List<Numeral_System_List_Item> Set_Numeral_System_List()
            {
                List<Numeral_System_List_Item> Output_Items_List = new List<Numeral_System_List_Item>();

                foreach (Numeral_System_Group numeral_Systems_Group in Used_Numeral_Systems.Numeral_Systems)
                {
                    for (sbyte numeral_System = numeral_Systems_Group.starting_Code;
                        numeral_System <= numeral_Systems_Group.finale_Code; numeral_System++)
                        Output_Items_List.Add(Factory.Get_Item(numeral_System));
                }

                return Output_Items_List;
            }
        }
    }
}
