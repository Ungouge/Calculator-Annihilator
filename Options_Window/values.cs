using System;
using System.Collections.Generic;
using Common_Library;
using Options_Library;
using Options_Window_Library;


namespace Options_Window
{
    partial class OptionsWindow
    {
        internal Bindable_Resources _Bindable_Resources;

        public IMainWindow Parent_MainWindow { get; private set; }

        internal List<IChange_Option_Command> Option_Change_Command_List;
    }
}
