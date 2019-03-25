using System;
using IMainWindow_Parameters;
using Options_Library;

namespace Calculator_Annihilator_Library
{
    /// <summary>
    /// Sets dynamic bindable resources of GUI elements of MainWindow.
    /// </summary>
    internal partial class Bindable_Resources : IBindable_Resources
    {
        private IMainWindow_For_Bindable_Resources MainWindow;

        /// <summary>
        /// Constructs new Bindable Resources class
        /// </summary>
        internal Bindable_Resources(IMainWindow_For_Bindable_Resources _MainWindow)
        {
            MainWindow = _MainWindow;
        }
    }
}