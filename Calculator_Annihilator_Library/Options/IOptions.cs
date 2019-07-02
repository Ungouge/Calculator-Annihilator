using Common_Library;
using Options_Library;

namespace Calculator_Annihilator_Library
{
    public interface IOptions: IOptions_Provider
    {
        Parser Parser { get; }

        Back_Parser_Fascede Back_Parser { get; }

        Numeral_System Current_Numeral_System { get; }

        Standard_Messages Standard_Messages { get; }
    }
}
