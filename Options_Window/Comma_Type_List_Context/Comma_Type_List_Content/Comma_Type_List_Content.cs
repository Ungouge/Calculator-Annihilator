using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Options_Window
{
    public class Comma_Type_List_Content: UserControl
    {
        public string Content_Text { get; protected set; }

        public double Text_Width { get; internal set; }

        public virtual bool Is_Selectable { get; }
    }
}
