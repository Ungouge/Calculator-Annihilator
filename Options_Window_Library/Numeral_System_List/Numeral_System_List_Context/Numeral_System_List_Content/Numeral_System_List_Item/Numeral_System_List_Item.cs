using System;

namespace Options_Window_Library
{
    /// <summary>
    /// Abstract class for selectable item with numeral system.
    /// </summary>
    public partial class Numeral_System_List_Item: Numeral_System_List_Content
    {
        public double Image_Width { get; internal set; }

        public virtual string Pin_Image_Uri { get;  }

        public sbyte Numeral_System_Code { get; protected set; }
    }
}
