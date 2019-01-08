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
			return Parser.Parse(WorkSpace.Text, Current_Numeral_System);
		}
	}
}
