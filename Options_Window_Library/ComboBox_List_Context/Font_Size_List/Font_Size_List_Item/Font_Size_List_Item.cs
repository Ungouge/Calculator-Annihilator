using System;
using Common_Library;

namespace Options_Window_Library
{
    /// <summary>
    /// Item with resources for Font_Size_List_ComboBox.
    /// </summary>
    public partial class Font_Size_List_Item
    {
        public string Font_Size_Name { get; private set; }

        public string Font_Size_Symbol_Uri { get; private set; }

        internal Font_Size_Type Font_Size;

        /// <summary>
        /// Constructs item for given Font_Size.
        /// </summary>
        internal Font_Size_List_Item(IStandard_Messages_Translate Standard_Messages, Font_Size_Type _Font_Size)
        {
            Font_Size = _Font_Size;

            Font_Size_Name = Standard_Messages.Translate(Font_Size.ToString() + "_Font_Size");

            Font_Size_Symbol_Uri = AppDomain.CurrentDomain.BaseDirectory + @"Library\Image\Font_Size\" + Font_Size.ToString() + "_Flag.png";
        }
    }
}