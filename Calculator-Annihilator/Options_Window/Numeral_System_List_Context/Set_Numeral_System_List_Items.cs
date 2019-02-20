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
        public partial class Numeral_System_List_Context
        {
            private List<Numeral_System_List_Item> Set_Numeral_System_List_Items()
            {
                List<Numeral_System_List_Item> Output_Items_List = new List<Numeral_System_List_Item>();

                foreach (sbyte[] numeral_Systems_Group in Used_Numeral_Systems.Numeral_Systems)
                {
                    for (sbyte i = numeral_Systems_Group[0]; i <= numeral_Systems_Group[numeral_Systems_Group.Length - 1]; i++)
                    {
                        Output_Items_List.Add(new Numeral_System_List_Item(Options_Window, i));
                    }
                }

                return Output_Items_List;
            }
        }
    }
}
