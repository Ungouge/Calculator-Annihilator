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
        internal void Set_Texts_Turntable(Standard_Messages standard_Messages)
        {
            GUI_Bindable_Resources.Set_Texts(standard_Messages);

            List<IMainWindow_Children> Children_List =
                Windows_Structure_Manager.Get_MainWindow_Children_List(this).This_Children_List;

            foreach (IMainWindow_Children children in Children_List)
            {
                children.Push_Set_Text(options.Standard_Messages);
            }
        }
    }
}
