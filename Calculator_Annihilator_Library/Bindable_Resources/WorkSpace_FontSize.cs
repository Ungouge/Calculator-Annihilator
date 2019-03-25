using System;

namespace Calculator_Annihilator_Library
{
    partial class Bindable_Resources
    {
        /// <summary>
        /// Gets font size for work space.
        /// </summary>
        public double WorkSpace_FontSize // Called by name by MainWindow.WorkSpace_TextChanged()
        {
            get
            {
                Font_To_TextBox_Matcher Matcher = new Font_To_TextBox_Matcher(MainWindow.Get_WorkSpace);

                return Matcher.Match_Font_To_TextBox();
            }
        }
    }
}