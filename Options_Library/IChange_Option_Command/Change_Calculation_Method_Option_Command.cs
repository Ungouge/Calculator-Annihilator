using System;
using Common_Library;

namespace Options_Library
{
    /// <summary>
    /// Changes font size type in Options class.
    /// </summary>
    public class Change_Calculation_Method_Option_Command : IChange_Option_Command
    {
        private readonly Calculation_Method Calculation_Method_To_Change;

        /// <summary>
        /// Constructs new command for changing font size type in Options class.
        /// </summary>
        public Change_Calculation_Method_Option_Command(Calculation_Method _Calculation_Method_To_Change)
        {
            Calculation_Method_To_Change = _Calculation_Method_To_Change;
        }

        /// <summary>
        /// Change font size type option in given Options class
        /// </summary>
        public void Change_Option(ISet_Options options)
        {
            options.Set_Calculation_Method(Calculation_Method_To_Change);
        }
    }
}