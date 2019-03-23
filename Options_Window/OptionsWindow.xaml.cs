using System;
using System.Collections.Generic;
using System.Windows;
using Common_Library;
using Options_Library;
using IOptions_Window;
using Windows_Structure;
using Options_Window_Library;

namespace Options_Window
{
    /// <summary>
    /// Interaction logic for OptionsWindow.xaml
    /// </summary>
    public partial class OWXYZ : Window, IMainWindow_Children, IOptionsWindow_Show, IOptionsWindow_Parameters
    {
        public OWXYZ(IGet_MainWindow_Parameters mainWindow)
        {
            // Preinitialization

            Parent_MainWindow = mainWindow;

            MainWindow = mainWindow;

            Windows_Manager.Add_Children_Window(this);

            Options = mainWindow.Get_Options;

            _Bindable_Resources = new Bindable_Resources(this);

            Option_Change_Command_List = new List<IChange_Option_Command>();
            
            _Numeral_System_List_Context = new Numeral_System_List_Context(_Bindable_Resources, MainWindow.Get_Standard_Messages, Options.Numeral_System_Code);

            _Number_Notation_List_Context = new Number_Notation_List_Context(MainWindow.Get_Standard_Messages, Options.Number_Notation);

            _Langauge_List_Context = new Langauge_List_Context(MainWindow.Get_Standard_Messages, Options.Current_Language);

            _Font_Size_List_Context = new Font_Size_List_Context(MainWindow.Get_Standard_Messages, Options.Font_Size_Type);

            _Comma_Type_List_Content = new Comma_Type_List_Context(this, _Bindable_Resources);
            
            this.DataContext = _Bindable_Resources;

            // Initialization

            InitializeComponent();

            // Postinitialization

            Number_Notation_List_ComboBox.DataContext = _Number_Notation_List_Context;

            Language_List_ComboBox.DataContext = _Langauge_List_Context;

            Font_Size_List_ComboBox.DataContext = _Font_Size_List_Context;

            Numeral_System_List_ComboBox.DataContext = _Numeral_System_List_Context;

            Comma_Type_List_ComboBox.DataContext = _Comma_Type_List_Content;
        }
    }
}
