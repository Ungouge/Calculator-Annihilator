using System;
using System.Windows.Input;

namespace Options_Window_Library
{
    internal partial class Add_New_Comma_Type_List_Item : Comma_Type_List_Item
    {
        public string New_Comma { get; set; }

        private Add_New_Comma_Type_Button_Command Add_New_Comma_Type_Command { get; set; }

        internal Add_New_Comma_Type_List_Item(string content_Text, Comma_Type_List_Context Comma_Type_List_Context) : base( content_Text)
        {
            Add_New_Comma_Type_Command =  new Add_New_Comma_Type_Button_Command(Comma_Type_List_Context);
        }

        public override bool Is_Selectable
        {
            get
            {
                return false;
            }
        }

        public ICommand Add_New_Comma_Type_Item_Button_Click
        {
            get
            {
                return Add_New_Comma_Type_Command;
            }
        }
    }
}
