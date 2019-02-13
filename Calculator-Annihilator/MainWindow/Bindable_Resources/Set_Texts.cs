using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        partial class Bindable_Resources
        {
            //public string  { get; set; }
            //public string  { get; set; }
            //public string  { get; set; }
            //public string  { get; set; }
            //public string  { get; set; }
            
            protected internal void Set_Texts(Standard_Messages standard_Messages)
            {
                Set_Calculator_annihilator_Text(standard_Messages);

                Set_Main_Menu_Text(standard_Messages);
            }
        }
    }
}
