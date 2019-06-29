using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Options_Window_Library
{
    internal class Label_Numeral_System_List: Numeral_System_List_Content, ILabel_Numeral_System_List
    {
        internal Label_Numeral_System_List(string content_Text)
        {
            Content_Text = content_Text;
        }
    }
}
