using System;
using System.Collections.Generic;
using Common_Library;
using Options_Library;
using Windows_Structure;
using Options_Window_Library;
using AnnihilatorWindowBase;

namespace Options_Window
{
    /// <summary>
    /// Interaction logic for OptionsWindow.xaml
    /// </summary>
    public partial class OptionsWindow : Annihilator_Window_Base, IMainWindow_Children, IOptionsWindow_Show
    {
        public OptionsWindow(IMainWindow _MainWindow, IOptions_Provider _Options_Provider)
        {
            // Preinitialization

            Parent_MainWindow = _MainWindow;

            Windows_Manager.Add_Children_Window(this);

            Options_Provider = _Options_Provider;

            _Bindable_Resources = new Bindable_Resources( Options_Provider);

            this.DataContext = _Bindable_Resources;

            Option_Change_Command_List = new List<IChange_Option_Command>();
            
            // Initialization

            InitializeComponent();
            
            // Postinitialization

            Set_Styles();
        }
    }
}
