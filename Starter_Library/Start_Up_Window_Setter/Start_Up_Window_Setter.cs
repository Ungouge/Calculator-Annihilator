using System;
using Options_Library;

namespace Starter_Library
{
    internal partial class Start_Up_Window_Setter
    {
        private readonly IOptions_Storage Options;

        public Start_Up_Window_Setter(IOptions_Storage _Options)
        {
            Options = _Options;
        }
    }
}
