using System;
using Common_Library;

namespace Calculator_Annihilator_Library
{
    partial class Options
    {
        public void Set_Language(Languages new_Language)
        {
            Current_Language = new_Language;

            Standard_Messages = new Standard_Messages(Current_Language,
                AppDomain.CurrentDomain.BaseDirectory + @"Library\Language_Library");

            MainWindow.Set_Texts_Turntable(Standard_Messages);

            MainWindow.Push_GUI_Recalculation();
        }
    }
}
