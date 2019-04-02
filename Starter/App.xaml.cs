using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Starter.Properties;
using Common_Library;
using Options_Library;
using Starter_Library;
using StartUpWindowBase;

namespace Starter
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Settings_File_Reader = new Settings_File_Reader(new Settings_Adapter(Settings.Default));

            Settings_File_Reader.Set_Do_Load_Hello_Window_Next_Run();

            IOptions_Storage Options = Settings_File_Reader.Get_Options_Storage;

            Start_Up_Window_Base Start_Up_Window = new Start_Up_Window_Setter(Options).Get_Start_Up_Window;

            Application Annihilation_Application = new Application();

            Annihilation_Application.Run(Start_Up_Window);
        }
    }
}
