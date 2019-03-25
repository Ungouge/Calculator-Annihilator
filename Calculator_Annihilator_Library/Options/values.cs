using System;
using Common_Library;
using IMainWindow_Parameters;

namespace Calculator_Annihilator_Library
{
    partial class Options
    {
        private IMainWindow_For_Options MainWindow;

        public Parser Parser { get; private set; }

        public Back_Parser_Fascede Back_Parser { get; private set; }

        public Numeral_System Current_Numeral_System { get; private set; }

        public Standard_Messages Standard_Messages { get; private set; }
    }
}

