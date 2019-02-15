using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
    /// <summary>
    /// Provides Machanism to change option in Options class.
    /// </summary>
    interface IChange_Option_Command
    {
        void Change_Option(Options options);
    }
}
