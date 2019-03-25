using System;
using IMainWindow_Parameters;

namespace Calculator_Annihilator
{
    partial class MainWindow: IMainWindow_For_Options
    {
        public void Push_GUI_Recalculation()
        {
            GUI_Bindable_Resources.Push_Recalculations();
        }
    }
}
