using System;

namespace Calculator_Annihilator
{
    partial class Settings_File_Reader
    {
        /// <summary>
        /// Pushes static resouces read from the settings file to Static_Resources 
        /// </summary>
        public void Push_MainWindow_Values(MainWindow _MainWindow)
        {
            _MainWindow.Set_Current_Numerical_System(numeral_System);
            _MainWindow.Current_Language = Language;
        }
    }
}
