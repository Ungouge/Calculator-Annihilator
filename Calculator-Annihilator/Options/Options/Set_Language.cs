using System;

namespace Calculator_Annihilator
{
    partial class Options
    {
        internal void Set_Language(Languages new_Language)
        {
            Current_Language = new_Language;

            Standard_Messages = new Standard_Messages(Current_Language,
                AppDomain.CurrentDomain.BaseDirectory + @"Library\Language_Library");

            Current_MainWindow.Set_Texts_Turntable(Standard_Messages);
        }
    }
}
