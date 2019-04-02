using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnnihilatorWindowBase;
using Options_Library;

namespace StartUpWindowBase
{
    abstract public class Start_Up_Window_Base: Annihilator_Window_Base
    {
        public Options_Storage Startup_Options { get; set; }
    }
}
