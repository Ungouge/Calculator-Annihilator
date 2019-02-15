using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Calculator_Annihilator
{
    /// <summary>
    /// Interaction logic for Options_Window.xaml
    /// </summary>
    public partial class Options_Window : Window, IMainWindow_Children
    {
        internal Options_Window(MainWindow mainWindow)
        {
            // Preinitialization

            Parent_MainWindow = mainWindow;

            Options = mainWindow.options;

            _Bindable_Resources = new Bindable_Resources(this);

            // Initialization

            InitializeComponent();

            // Postinitialization
            
            this.DataContext = _Bindable_Resources;

            Option_Change_Command_List = new List<IChange_Option_Command>();
        }
    }
}
