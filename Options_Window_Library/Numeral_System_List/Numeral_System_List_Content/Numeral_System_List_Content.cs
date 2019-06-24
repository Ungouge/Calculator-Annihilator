using System;
using System.Windows.Controls;

namespace Options_Window_Library
{
    /// <summary>
    /// Abstract item UserControl class with resources for Numeral_System_List_ComboBox.
    /// </summary>
    internal abstract partial class Numeral_System_List_Content : INumeral_System_List_Content
    {
        public string Content_Text { get; protected internal set; }

        public virtual bool Is_Enabled { get;} 
    }
}
