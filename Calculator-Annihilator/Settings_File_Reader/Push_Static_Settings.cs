using System;

namespace Calculator_Annihilator
{
     internal partial class Settings_File_Reader
    {
        /// <summary>
        /// Pushes static resouces read from the settings file to Static_Resources 
        /// </summary>
        public void Push_Static_Settings(MainWindow.Static_Resources Static_Resources)
        {
            if (calculator_Mode == Calculator_Mode.Standard)
            {
                Static_Resources.Number_Columns_In_ButtonGrid = 5;
                Static_Resources.Number_Rows_In_ButtonGrid = 4;
            }
            else
            {
                Static_Resources.Number_Columns_In_ButtonGrid = 7;
                Static_Resources.Number_Rows_In_ButtonGrid = 4;
            }
        }
    }

}
