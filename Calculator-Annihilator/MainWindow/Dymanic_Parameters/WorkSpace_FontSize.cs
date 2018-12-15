using System;

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        partial class Dynamic_Parameters
        {
            /// <summary>
            /// Gets font size for work space.
            /// </summary>
            public double WorkSpace_FontSize // Called by name by MainWindow.WorkSpace_TextChanged()
            {
                get
                {
                    Font_To_TextBox_Matcher Matcher = new Font_To_TextBox_Matcher(Current_Window.WorkSpace);

                    return Matcher.Match_Font_To_TextBox();
                }
            }
        }
    }
}