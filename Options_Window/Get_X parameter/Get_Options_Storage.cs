using System;
using IOptionsWindow_Parameters;
using Options_Library;


namespace Options_Window
{
    partial class OptionsWindow : IOptionsWindow_Get_Options_Storage
    {
        public IOptions_Storage Get_Options_Storage
        {
            get
            {
                return Options;
            }
        }
    }
}
