using System;
using Common_Library;
using Options_Library;
using System.Collections.Generic;

namespace Options_Window_Library
{
    partial class Numeral_System_List_Context
    {
        /// <summary>
        /// Class for setting a Numeral_System items list including pinned numeral system on top and managing pinning
        /// and unpinnig numeral systems in this list.
        /// </summary>
        internal partial class Numeral_System_Items_List
        {
            private List<Numeral_System_List_Item> Items_List;

            private List<Numeral_System_List_Item> Pinned_Items_List;

            private Numeral_System_List_Content_Factory Factory;

            /// <summary>
            /// Constructs Numeral_System_Items_List
            /// </summary>
            public Numeral_System_Items_List(Numeral_System_List_Context Numeral_System_List_Context,Bindable_Resources Bindable_Resources, IStandard_Messages_Translate Standard_Messages)
            {
                Factory = new Numeral_System_List_Content_Factory(Bindable_Resources, Standard_Messages);

                Pinned_Items_List = Set_Pinned_Numeral_System_List(Numeral_System_List_Context);

                Items_List = Set_Numeral_System_List(Numeral_System_List_Context);
            }

            /// <summary>
            /// Sets list of pinned Numeral_System or empty list if there is no pinned Numeral_Systems.
            /// </summary>
            private List<Numeral_System_List_Item> Set_Pinned_Numeral_System_List(Numeral_System_List_Context Numeral_System_List_Context)
            {
                List<Numeral_System_List_Item> Output_Items_List = new List<Numeral_System_List_Item>();

                if (Pinned_Numeral_Systems.Get_Numeral_Systems_Codes.Length > 0)
                    foreach (sbyte numeral_System in Pinned_Numeral_Systems.Get_Numeral_Systems_Codes)
                        Output_Items_List.Add(Factory.Get_Item(Numeral_System_List_Context, numeral_System));

                return Output_Items_List;
            }

            /// <summary>
            /// Sets list of Numeral_Systems.
            /// </summary>
            private List<Numeral_System_List_Item> Set_Numeral_System_List(Numeral_System_List_Context Numeral_System_List_Context)
            {
                List<Numeral_System_List_Item> Output_Items_List = new List<Numeral_System_List_Item>();

                foreach (Numeral_System_Group numeral_Systems_Group in Used_Numeral_Systems.Numeral_Systems)
                {
                    for (sbyte numeral_System = numeral_Systems_Group.starting_Code;
                        numeral_System <= numeral_Systems_Group.finale_Code; numeral_System++)
                    {
                        Output_Items_List.Add(Factory.Get_Item(Numeral_System_List_Context, numeral_System));
                    }
                }

                return Output_Items_List;
            }
        }
    }
}
