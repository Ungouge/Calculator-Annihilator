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
using Common_Library;
using Windows_Structure;

namespace Options_Window
{
    /// <summary>
    /// Interaction logic for OptionsWindow.xaml
    /// </summary>
    public partial class OWXYZ : Window, IMainWindow_Children, IOptionsWindow
    {
        public OWXYZ(IMainWindow mainWindow)
        {
            // Preinitialization

            Parent_MainWindow = mainWindow;

            Windows_Manager.Add_Children_Window(this);

            Options = mainWindow.Get_Options;

            _Bindable_Resources = new Bindable_Resources(this);

            // Initialization

            InitializeComponent();

            // Postinitialization

            _Number_Notation_List_Context = new Number_Notation_List_Context(this);

            Number_Notation_List_ComboBox.DataContext = _Number_Notation_List_Context;

            _Langauge_List_Context = new Langauge_List_Context(this);

            Language_List_ComboBox.DataContext = _Langauge_List_Context;

            _Font_Size_List_Context = new Font_Size_List_Context(this);

            Font_Size_List_ComboBox.DataContext = _Font_Size_List_Context;

            _Numeral_System_List_Context = new Numeral_System_List_Context(this);

            Numeral_System_List_ComboBox.DataContext = _Numeral_System_List_Context;

            this.DataContext = _Bindable_Resources;

            Option_Change_Command_List = new List<IChange_Option_Command>();
        }
    }
}
