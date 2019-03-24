using System;
using System.Windows.Controls;

namespace Options_Window_Library
{
    /// <summary>
    /// Abstract item UserControl class with resources for Numeral_System_List_ComboBox.
    /// </summary>
    public abstract partial class Numeral_System_List_Content : UserControl
    {
        public string Content_Text { get; internal set; }

        public double Text_Width { get; internal set; }

        public virtual bool Is_Enabled { get;} 
    }
}
