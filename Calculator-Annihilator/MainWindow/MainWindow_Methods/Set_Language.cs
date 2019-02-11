using System;

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        private void Set_Language(Languages Language)
        {
            Standard_Messages = new Standard_Messages(Language,
                AppDomain.CurrentDomain.BaseDirectory + @"Library\Language_Library");
        }
    }
}
