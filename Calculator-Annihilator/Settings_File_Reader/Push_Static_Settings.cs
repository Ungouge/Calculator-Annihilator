using System;

namespace Calculator_Annihilator
{
    partial class Settings_File_Reader
    {
        /// <summary>
        /// Pushes static resouces read from the settings file to Static_Resources 
        /// </summary>
        public void Push_Static_Settings(MainWindow _MainWindow, MainWindow.Static_Resources _Static_Resources)
        {
            _Static_Resources.Calculation_Method = calculation_Method;

            _Static_Resources.Calculator_Mode = calculator_Mode;


            // to remove static will calculate this on run.
            if (calculator_Mode == Calculator_Mode.Standard)
            {
                //_MainWindow.Standard_MenuButton.IsChecked = true;
                _Static_Resources.Number_Columns_In_ButtonGrid = 5;
                _Static_Resources.Number_Rows_In_ButtonGrid = 4;
            }
            else
            {
                //_MainWindow.Scientific_MenuButton.IsChecked = true;
                _Static_Resources.Number_Columns_In_ButtonGrid = 7;
                _Static_Resources.Number_Rows_In_ButtonGrid = 4;
            }
        }
    }
}
