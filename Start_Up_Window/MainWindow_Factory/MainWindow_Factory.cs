using System;
using Options_Library;

namespace Start_Up_Window
{
    public partial class MainWindow_Factory
    {
        private readonly IOptions_Storage Options;

        public MainWindow_Factory(IOptions_Storage _Options)
        {
            Options = _Options;
        }
    }
}
