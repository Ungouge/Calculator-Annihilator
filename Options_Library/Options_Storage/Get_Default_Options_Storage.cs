using System;
using Common_Library;

namespace Options_Library
{
    public partial class Options_Storage
    {
        public static IOptions_Storage Get_Default_Options_Storage
        {
            get
            {
                return new Options_Storage(
                    Calculator_Mode.Standard,
                    Calculation_Method.Single,
                    510,
                    420,
                    Number_Notation.Normal,
                    System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator,
                    Font_Size_Type.Normal,
                    10,
                    Languages.English
                );
            }
        }
    }
}
