using System;
using System.Collections.Generic;
using Common_Library;
using Options_Library;
using Options_Window_Library;


namespace Options_Window
{
    partial class OWXYZ
    {
        internal Bindable_Resources _Bindable_Resources;

        private Number_Notation_List_Context _Number_Notation_List_Context;

        private Langauge_List_Context _Langauge_List_Context;

        private Font_Size_List_Context _Font_Size_List_Context;

        private Numeral_System_List_Context _Numeral_System_List_Context;

        private Comma_Type_List_Context _Comma_Type_List_Content;

        public IMainWindow Parent_MainWindow { get; private set; }

        public IGet_MainWindow_Parameters MainWindow { get; set; }

        public IOptions Options { get; private set; }

        public IOptions_Provider Get_Options_Provider
        {
            get
            {
                return Options;
            }
        }

        internal ISet_Options Get_Options_Set
        {
            get
            {
                return Options;
            }
        }

        internal List<IChange_Option_Command> Option_Change_Command_List;
    }
}
