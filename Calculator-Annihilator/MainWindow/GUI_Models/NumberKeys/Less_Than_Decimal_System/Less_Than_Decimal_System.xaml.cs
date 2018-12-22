using System;
using System.Windows;
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
            this.DataContext = _MainWindow.GUI_Dynamic_Parameters;

            Calculation_Method calculation_Method = MainWindow._Static_Resources.Calculation_Method;

            Open_Bracket_Or_Change_Sign_Exchanger Open_Change_Exchanger =
                new Open_Bracket_Or_Change_Sign_Exchanger();

            Open_Change_Exchanger.Set_Open_Bracket_Or_Change_Sign_Button(
                    Button_Open_Bracket_Or_Change_Sign, calculation_Method, this);

            Close_Bracket_Or_Invert_Number_Exchanger Close_Invert_Exchanger =
                new Close_Bracket_Or_Invert_Number_Exchanger();

            Close_Invert_Exchanger.Set_Close_Bracket_Or_Invert_Number_Button(
                    Button_Close_Bracket_Or_Invert_Number, calculation_Method, this);
        }
    }
}
