using System;
using System.Collections.Generic;
using System.Windows;
using Common_Library;
using Options_Library;
using IOptionsWindow_Parameters;
using Windows_Structure;
using Options_Window_Library;

namespace Options_Window
{
    /// <summary>
    /// Interaction logic for OptionsWindow.xaml
    /// </summary>
    public partial class OptionsWindow : Window, IMainWindow_Children, IOptionsWindow_Show, IOptionsWindow_For_Comma_Type_List_Context
    {
        public OptionsWindow(IGet_MainWindow_Parameters _MainWindow)
        {
            // Preinitialization

            Parent_MainWindow = _MainWindow;

            Windows_Manager.Add_Children_Window(this);

            Options = _MainWindow.Get_Options;

            _Bindable_Resources = new Bindable_Resources(this, Options.Font_Size_Type);

            Option_Change_Command_List = new List<IChange_Option_Command>();
            
            _Numeral_System_List_Context = new Numeral_System_List_Context(_Bindable_Resources, Options.Get_Standard_Messages_Translate, Options.Numeral_System_Code);

            _Number_Notation_List_Context = new Number_Notation_List_Context(Options.Get_Standard_Messages_Translate, Options.Number_Notation);

            _Langauge_List_Context = new Langauge_List_Context(Options.Get_Standard_Messages_Translate, Options.Current_Language);

            _Font_Size_List_Context = new Font_Size_List_Context(Options.Get_Standard_Messages_Translate, Options.Font_Size_Type);

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
