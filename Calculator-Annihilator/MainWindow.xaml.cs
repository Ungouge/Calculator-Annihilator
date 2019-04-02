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
using System.Windows.Navigation;
using System.Windows.Shapes;

using Common_Library;
using Windows_Structure;
using Options_Library;
using Calculator_Annihilator_Library;
using IMainWindow_Parameters;
using StartUpWindowBase;

namespace Calculator_Annihilator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Start_Up_Window_Base, IMainWindow, IGet_MainWindow_Parameters, IMainWindow_For_Bindable_Resources
    {
        public MainWindow(IOptions_Storage _Options)
        {
            try
            {
                // Preinitialization
                Windows_Manager.Add_MainWindow(this);
                
                GUI_Bindable_Resources = new Bindable_Resources_Factory(this).Get_Bindable_Resources;

                Options = (new Options_Factory(this)).Get_Options(_Options);

                GUI_Bindable_Resources.Intialize_MainWindow_Size(Options);

                // Initialization

                InitializeComponent();

                // Postinitialization

                this.DataContext = GUI_Bindable_Resources;

                ComplexCalculations.DataContext = GUI_Bindable_Resources;
                Calculator_Buttons_Panel_Setter();


                if (Options.Calculation_Method == Calculation_Method.Single)
                    this.SingleCalculations.IsChecked = true;
                else // calculation_Method == Calculation_Method.Complex
                    this.ComplexCalculations.IsChecked = true;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
    }
}
