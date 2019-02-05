﻿using System;

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        partial class Dynamic_Parameters
        {
            private MainWindow Current_Window;

            /// <summary>
            /// Contains names of fields that should be recalculated at MainWindow state change
            /// </summary>
            static readonly private string[] Names_Of_properties_To_Handle = new string[]
            {
                "Button_FontSize", "WorkSpace_FontSize", "ResultSpace_FontSize", "Calculation_Type_Radio_Buttons_FontSize"
            };
        }
    }
}