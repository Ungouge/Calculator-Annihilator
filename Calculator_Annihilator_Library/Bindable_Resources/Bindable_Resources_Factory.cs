using System;
using IMainWindow_Parameters;
using Options_Library;

namespace Calculator_Annihilator_Library
{
    public class Bindable_Resources_Factory
    {
        private readonly IMainWindow_For_Bindable_Resources MainWindow;

        public Bindable_Resources_Factory(IMainWindow_For_Bindable_Resources _MainWindow)
        {
            MainWindow = _MainWindow;
        }

        public IBindable_Resources Get_Bindable_Resources
        {
            get
            {
                return new Bindable_Resources(MainWindow);
            }
        }

    }
}