using System;

namespace Options_Window_Library
{
    internal class Comma_Type_List_Item : IComma_Type_List_Item
    {
        public string Content_Text { get; protected set; }

        internal Comma_Type_List_Item(string content_Text)
        {
            Content_Text = content_Text;
        }

        public virtual bool Is_Selectable
        {
            get
            {
                return true;
            }
        }
    }
}
