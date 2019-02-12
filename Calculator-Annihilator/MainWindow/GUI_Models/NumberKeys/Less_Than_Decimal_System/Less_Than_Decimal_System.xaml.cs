using System;
using System.Windows.Controls;

namespace Calculator_Annihilator
{
    /// <summary>
    /// Interaction logic for Less_than_Decimal_System.xaml
    /// </summary>
    public partial class Less_Than_Decimal_System : UserControl, IButton_Changer
    {
        MainWindow MainWindow;

        public Less_Than_Decimal_System(MainWindow _MainWindow)
        {
            MainWindow = _MainWindow;
            InitializeComponent();
            this.DataContext = _MainWindow.GUI_Bindable_Resources;

            Set_Open_Bracket_Or_Change_Sign_Button();

            Set_Close_Bracket_Or_Invert_Number_Button();
        }

        public void Set_Open_Bracket_Or_Change_Sign_Button()
        {
            Open_Bracket_Or_Change_Sign_Exchanger Open_Change_Exchanger = new Open_Bracket_Or_Change_Sign_Exchanger();

            Open_Change_Exchanger.Set_Open_Bracket_Or_Change_Sign_Button(
                    Button_Open_Bracket_Or_Change_Sign, MainWindow.options.Calculation_Method, this as IButton_Changer);
        }

        public void Set_Close_Bracket_Or_Invert_Number_Button()
        {
            Close_Bracket_Or_Invert_Number_Exchanger Close_Invert_Exchanger =
                new Close_Bracket_Or_Invert_Number_Exchanger();

            Close_Invert_Exchanger.Set_Close_Bracket_Or_Invert_Number_Button(
                    Button_Close_Bracket_Or_Invert_Number, MainWindow.options.Calculation_Method, this as IButton_Changer);
        }
    }
}
