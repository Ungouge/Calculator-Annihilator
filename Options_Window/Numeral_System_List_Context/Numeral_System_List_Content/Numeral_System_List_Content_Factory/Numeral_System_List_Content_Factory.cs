using System;
using Common_Library;

namespace Options_Window
{
    internal partial class Numeral_System_List_Content_Factory
    {
        protected string label_Text;

        public Numeral_System_List_Content_Factory(Standard_Messages _Standard_Messages): this(
                _Standard_Messages.Translate("All_Numeral_system"))
        { }
        

        public Numeral_System_List_Content_Factory( string _label_Text)
        {
            label_Text = _label_Text;
        }
    }
}