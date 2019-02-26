using System;
using Common_Library;

namespace Calculator_Annihilator
{
    partial class Options
    {
        private MainWindow Current_MainWindow;

        internal Parser Parser { get; private set; }

        internal Numeral_System Current_Numeral_System { get; private set; }

        public Standard_Messages Standard_Messages { get; private set; }

        internal string[] Commas_Type_Array { get; private set; } = Signs_Lib.Commas_Type;
    }
}

