using System;

namespace Calculator_Annihilator_Library
{
    /// <summary>
    /// Interface for classes capable of back parsing numbers in numeral systems separating 
    /// number into coeficient and exponent.
    /// </summary>
    interface IBack_Parser
    {
        string Get_Coeficient { get; }

        short Get_Exponent_Value { get; }

        string Exponent_In_Numeral_System_To_String(short exponent);

        byte Numeral_System_Precition { get; }

        sbyte Numeral_System_Type { get; }
    }
}
