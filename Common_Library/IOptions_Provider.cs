namespace Common_Library
{
    public interface IOptions_Provider
    {
        Calculator_Mode Calculator_Mode { get; }

        Calculation_Method Calculation_Method { get; }

        double Initial_Height { get; }

        double Initial_Width { get; }

        Number_Notation Number_Notation { get;  }

        Font_Size_Type Font_Size_Type { get;  }

        sbyte Numeral_System_Code { get;  }

        sbyte[] Pined_Numeral_Systems { get; }

        Languages Current_Language { get; }

        Standard_Messages Standard_Messages { get; }

        string Comma_Type { get; }

        void Set_Comma_Type(string new_Comma_Type);

        void Set_Font_Size_Type(Font_Size_Type new_Font_Size_Type);

        void Set_Language(Languages new_Language);

        void Set_Number_Notation(Number_Notation new_Number_Notation);

        void Set_Numeral_System(sbyte new_Numeral_System_Code);
    }
}
