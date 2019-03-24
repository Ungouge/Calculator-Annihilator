using System;

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        partial class Bindable_Resources
        {
            /// <summary>
            /// Gets font size for result space.
            /// </summary>
            public double ResultSpace_FontSize // Called by name by MainWindow.WorkSpace_TextChanged()
            {
                get
                {
                    Font_To_TextBox_Matcher Matcher = new Font_To_TextBox_Matcher(Current_Window.ResultSpace);

                    return Matcher.Match_Font_To_TextBox();
                }
            }
        }
    }
}
