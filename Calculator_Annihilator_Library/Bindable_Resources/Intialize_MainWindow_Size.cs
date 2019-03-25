using System;
using Options_Library;

namespace Calculator_Annihilator_Library
{
    partial class Bindable_Resources
    {
        public void Intialize_MainWindow_Size(IOptions_Storage Options)
        {
            Window_Height = Options.Initial_Height;
            Window_Width = Options.Initial_Width;
        }
    }
}
