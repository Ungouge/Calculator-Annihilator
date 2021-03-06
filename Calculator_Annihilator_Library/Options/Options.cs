﻿using System;
using IMainWindow_Parameters;
using Options_Library;

namespace Calculator_Annihilator_Library
{
    internal partial class Options : Options_Storage, IOptions
    {
        /// <summary>
        /// Constructs new Options class reading and setting resorcess for MainWindow .
        /// </summary>
        internal Options(IMainWindow_For_Options mainWindow , IOptions_Storage options) : base(options.Calculator_Mode,
            options.Calculation_Method, options.Initial_Height, options.Initial_Width,
            options.Number_Notation, options.Font_Size_Type, options.Colour_Palette_Type)
        {
            MainWindow = mainWindow;
            Set_Comma_Type(options.Comma_Type);
            Set_Numeral_System(options.Numeral_System_Code);
            Set_Language(options.Current_Language);
        }
    }
}