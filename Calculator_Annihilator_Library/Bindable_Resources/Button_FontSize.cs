﻿using System;

namespace Calculator_Annihilator_Library
{
    partial class Bindable_Resources
    {
        const double Height_Or_Width_Switch_Ration = 12e-1;

        /// <summary>
        /// Gets font size for buttons based on actual window size.
        /// </summary>
        public double Button_FontSize
        {
            get
            {
                double _Actual_Button_Height =
                    MainWindow.Get_ButtonsGrid.ActualHeight / 7;// Current_Window._Static_Resources.Number_Rows_In_ButtonGrid;

                double _Actual_Button_Weidth =
                    MainWindow.Get_ButtonsGrid.ActualWidth / 4;// Current_Window._Static_Resources.Number_Columns_In_ButtonGrid;

                if (_Actual_Button_Weidth / _Actual_Button_Height > Height_Or_Width_Switch_Ration)
                    return _Actual_Button_Height / 2;
                else
                    return (_Actual_Button_Weidth / (2 * Height_Or_Width_Switch_Ration));
            }
        }
    }
}