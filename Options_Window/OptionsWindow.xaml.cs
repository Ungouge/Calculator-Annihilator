﻿using System;
using System.Collections.Generic;
using System.Windows;
using Common_Library;
using Options_Library;

using Windows_Structure;

namespace Options_Window
{
    /// <summary>
    /// Interaction logic for OptionsWindow.xaml
    /// </summary>
    public partial class OWXYZ : Window, IMainWindow_Children, IOptionsWindow
    {
        public OWXYZ(IGet_MainWindow_Options mainWindow)
        {
            // Preinitialization

            Parent_MainWindow = mainWindow;

            Windows_Manager.Add_Children_Window(this);

            Options = mainWindow.Get_Options;

            _Bindable_Resources = new Bindable_Resources(this);

            Option_Change_Command_List = new List<IChange_Option_Command>();


            _Numeral_System_List_Context = new Numeral_System_List_Context(this);

            _Number_Notation_List_Context = new Number_Notation_List_Context(this);

            _Langauge_List_Context = new Langauge_List_Context(this);

            _Font_Size_List_Context = new Font_Size_List_Context(this);

            _Comma_Type_List_Content = new Comma_Type_List_Context(this);
            
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
