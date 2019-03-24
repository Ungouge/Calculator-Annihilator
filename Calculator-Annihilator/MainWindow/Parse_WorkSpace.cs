using System;

namespace Calculator_Annihilator
{
	partial class MainWindow // Parse_Workspace
	{
		/// <summary>
		/// Parses current Text in workspace to number according to current numerical system. 
		/// </summary>
		private Number Parse_WorkSpace()
		{
            //if (String.IsNullOrEmpty(WorkSpace.Text)) // xyz: fix errors when empty work space like this or by implementin no actions when ws empty
            //    return new Number(0);
            //else
                return Parser.Parse(WorkSpace.Text);
		}
	}
}
