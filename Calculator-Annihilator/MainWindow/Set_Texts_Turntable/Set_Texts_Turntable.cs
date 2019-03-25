using System;
using System.Collections.Generic;
using Common_Library;

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        public void Set_Texts_Turntable(IStandard_Messages_Translate standard_Messages)
        {
            GUI_Bindable_Resources.Set_Texts(standard_Messages);

            List<IMainWindow_Children> Children_List =
                Windows_Structure.Windows_Manager.Get_MainWindow_Children_List(this).This_Children_List;

            foreach (IMainWindow_Children children in Children_List)
            {
                children.Push_Set_Text(Options.Standard_Messages);
            }
        }
    }
}
