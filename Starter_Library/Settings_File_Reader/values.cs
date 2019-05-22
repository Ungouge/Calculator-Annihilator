using System;
using Common_Library;
using Options_Library;

namespace Starter_Library
{
    partial class Settings_File_Reader
    {
        private Options_Storage Options;

        private ISettings_Adapter Settings;

        private Calculator_Mode Calculator_Mode;

        private Calculation_Method Calculation_Method;

        private double initial_Height;

        private double initial_Width;

        private Number_Notation Number_Notation;

        private string comma_Type;

        private Font_Size_Type Font_Size_Type;

        private Colour_Palette_Type Colour_Palette_Type;

        private sbyte numeral_System;

        private Languages Language;
    }
}