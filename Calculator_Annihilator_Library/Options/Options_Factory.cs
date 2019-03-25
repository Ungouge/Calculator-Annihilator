using System;
using Options_Library;
using IMainWindow_Parameters;

namespace Calculator_Annihilator_Library
{
    public class Options_Factory
    {
        private readonly IMainWindow_For_Options MainWindow;

        public Options_Factory(IMainWindow_For_Options _MainWindow)
        {
            MainWindow = _MainWindow;
        }

        public IOptions Get_Options(Options_Storage _Options)
        {
            return new Options(MainWindow, _Options);
        }
    }
}
