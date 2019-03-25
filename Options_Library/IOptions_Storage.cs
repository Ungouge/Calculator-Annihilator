using Common_Library;

namespace Options_Library
{
    public interface IOptions_Storage
    {
        Calculator_Mode Calculator_Mode { get; }

        Calculation_Method Calculation_Method { get; }

        double Initial_Height { get; }

        double Initial_Width { get; }

        Number_Notation Number_Notation { get;  }

        Font_Size_Type Font_Size_Type { get;  }

        sbyte Numeral_System_Code { get;  }

        Languages Current_Language { get; }

        string Comma_Type { get; }

        string[] Commas_Type_Array { get;}
    }
}
