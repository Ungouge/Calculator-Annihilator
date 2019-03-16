using System.Windows.Controls;

namespace Options_Window
{
    public partial class Numeral_System_List_Content : UserControl
    {
        public string Content_Text { get; internal set; }

        public double Text_Width { get; internal set; }

        public virtual bool Is_Enabled { get;} 
    }
}
