using Common_Library;
using Options_Library;

namespace Calculator_Annihilator_Library
{
    public interface IOptions: IOptions_Provider
    {
        Parser Parser { get; }

        Numeral_System Current_Numeral_System { get; }

        Standard_Messages Standard_Messages { get; }

        void Set_Calculation_Method(Calculation_Method _Calculation_Method);

        void Set_Calculator_Mode(Calculator_Mode _Calculator_Mode);
    }
}
