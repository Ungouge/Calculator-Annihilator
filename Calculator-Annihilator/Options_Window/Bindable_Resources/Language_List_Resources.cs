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
    public partial class Options_Window : Window
    {
        public partial class Bindable_Resources
        {
            public string English_Flag_Uri { get; set; }
            public string Polish_Flag_Uri { get; set; }
            public string German_Flag_Uri { get; set; }
            public string Latin_Flag_Uri { get; set; }
            public string Chinese_Flag_Uri { get; set; }

            public string English  { get; set; }
            public string Polish { get; set; }
            public string German { get; set; }
            public string Latin { get; set; }
            public string Chinese  { get; set; }

            private void Set_Language_List_Bidables()
            {
                English_Flag_Uri  = AppDomain.CurrentDomain.BaseDirectory + @"Library\Language_Flags_Images\English_Flag.png";
                Polish_Flag_Uri  = AppDomain.CurrentDomain.BaseDirectory + @"Library\Language_Flags_Images\Polish_Flag.png";
                German_Flag_Uri  = AppDomain.CurrentDomain.BaseDirectory + @"Library\Language_Flags_Images\German_Flag.png";
                Latin_Flag_Uri   = AppDomain.CurrentDomain.BaseDirectory + @"Library\Language_Flags_Images\Latin_Flag.png";
                Chinese_Flag_Uri = AppDomain.CurrentDomain.BaseDirectory + @"Library\Language_Flags_Images\Chinese_Flag.png";

                English = Options_Window.Standard_Messages.Translate("English");
                Polish  = Options_Window.Standard_Messages.Translate("Polish");
                German  = Options_Window.Standard_Messages.Translate("German");
                Latin   = Options_Window.Standard_Messages.Translate("Latin");
                Chinese = Options_Window.Standard_Messages.Translate("Chinese");
            }
        }
    }
}
