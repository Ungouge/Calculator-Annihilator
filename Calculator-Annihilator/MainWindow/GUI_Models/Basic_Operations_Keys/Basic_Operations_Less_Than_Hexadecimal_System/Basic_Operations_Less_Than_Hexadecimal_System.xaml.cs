using System;
using System.Windows.Controls;

namespace Calculator_Annihilator
{
    /// <summary>
    /// Interaction logic for Basic_Operations_Less_Than_Hexadecimal_System.xaml
    /// </summary>
    public partial class Basic_Operations_Less_Than_Hexadecimal_System : UserControl
    {
        MainWindow MainWindow;

        public Basic_Operations_Less_Than_Hexadecimal_System(MainWindow _MainWindow)
        {
            MainWindow = _MainWindow;
            InitializeComponent();
            this.DataContext = _MainWindow.GUI_Bindable_Resources;
        }
    }
}
