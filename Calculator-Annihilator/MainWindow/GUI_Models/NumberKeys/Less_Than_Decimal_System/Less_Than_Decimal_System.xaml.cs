using System;
using System.Windows.Controls;

namespace Calculator_Annihilator
{
    /// <summary>
    /// Interaction logic for Less_than_Decimal_System.xaml
    /// </summary>
    public partial class Less_Than_Decimal_System : UserControl
    {
        MainWindow MainWindow;

        public Less_Than_Decimal_System(MainWindow _MainWindow)
        {
            MainWindow = _MainWindow;
            InitializeComponent();
            this.DataContext = _MainWindow.GUI_Dynamic_Parameters;
        }
    }
}
