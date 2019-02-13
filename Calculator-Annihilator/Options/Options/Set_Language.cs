using System;

namespace Calculator_Annihilator
{
    partial class Options
    {
        internal void Set_Language(Languages new_Numeral_System_Base)
        {
            Current_Language = new_Numeral_System_Base;

            Standard_Messages = new Standard_Messages(Current_Language,
                AppDomain.CurrentDomain.BaseDirectory + @"Library\Language_Library");

            Current_MainWindow.Set_Texts_Turntable(Standard_Messages);
        }
    }
}
