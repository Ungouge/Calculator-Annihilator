using Common_Library;
using Options_Library;

namespace Calculator_Annihilator_Library
{
    public interface IBindable_Resources
    {
        double Button_FontSize { get; }
        double Calculation_Type_Radio_Buttons_FontSize { get; }
        string Close_Window { get; set; }
        string Complex_Calculations { get; set; }
        string Edit { get; set; }
        string File { get; set; }
        string Help { get; set; }
        string New_Window { get; set; }
        string Options { get; set; }
        double ResultSpace_FontSize { get; }
        string Scientific { get; set; }
        string Single_Calculations { get; set; }
        string Standard { get; set; }
        string Title { get; set; }
        string View { get; set; }
        double Window_Height { get; set; }
        double Window_Width { get; set; }
        double WorkSpace_FontSize { get; }

        void Intialize_MainWindow_Size(IOptions_Storage Options);
        void Recalculate_Property(string Property_Name);
        void Push_Recalculations();
        void Set_Texts(IStandard_Messages_Translate standard_Messages);
    }
}