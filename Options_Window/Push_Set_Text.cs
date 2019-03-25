using System;
using Common_Library;

namespace Options_Window
{
    partial class OptionsWindow
    {
        void IMainWindow_Children.Push_Set_Text(Standard_Messages standard_Messages)
        {
            _Bindable_Resources.Set_Text(standard_Messages);

            Set_Text(standard_Messages);
        }
    }
}
