using System;

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        /// <summary>
        /// Pushes specialized buttons configuration acording to current calculation method.
        /// </summary>
        private void Set_Specialized_Buttons()
        {
            IButton_Changer Button_Panel;

            if (NumberKeys_ContextControl.DataContext is IButton_Changer)
            {
                Button_Panel = NumberKeys_ContextControl.DataContext as IButton_Changer;
            }
            else // BasicOperations_ContextControl.DataContextif (BasicOperations_ContextControl.DataContext is IButton_Changer)
            {
                Button_Panel = BasicOperations_ContextControl.DataContext as IButton_Changer;
            }

            Button_Panel.Set_Close_Bracket_Or_Invert_Number_Button();
            Button_Panel.Set_Open_Bracket_Or_Change_Sign_Button();
        }
    }
}
