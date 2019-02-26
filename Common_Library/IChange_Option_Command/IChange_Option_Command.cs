using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_Library
{
    /// <summary>
    /// Provides Machanism to change option in Options class.
    /// </summary>
    public interface IChange_Option_Command
    {
        void Change_Option(IOptions_Provider options);
    }
}
