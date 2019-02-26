using System;
using Common_Library;

namespace Calculator_Annihilator
{
    partial class Options
    {
        public void Set_Language(Languages new_Language)
        {
            Current_Language = new_Language;

            Standard_Messages = new Standard_Messages(Current_Language,
                AppDomain.CurrentDomain.BaseDirectory + @"Library\Language_Library");

            Current_MainWindow.Set_Texts_Turntable(Standard_Messages);

            Current_MainWindow.GUI_Bindable_Resources.Push_Recalculations();
        }
    }
}
