using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

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
            bool Do_load_Hello_Window = false;

            Window Window_To_Load;

            if (Do_load_Hello_Window == false)
            {
                Window_To_Load = new Calculator_Annihilator.MainWindow();
            }
            else
            {
                Window_To_Load = null; // Hello_Window();
            }

            Application Annihilation_Application = new Application();

            Annihilation_Application.Run(Window_To_Load);
        }
    }
}
