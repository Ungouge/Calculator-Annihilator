using System;

namespace Calculator_Annihilator
{
    partial class Options
    {
        private void Set_Language(Languages new_Numeral_System_Base)
        {
            Current_Language = new_Numeral_System_Base;

            Standard_Messages = new Standard_Messages(Current_Language,
                AppDomain.CurrentDomain.BaseDirectory + @"Library\Language_Library");
        }
    }
}
