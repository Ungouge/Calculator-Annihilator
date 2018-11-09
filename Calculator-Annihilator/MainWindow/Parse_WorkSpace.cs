using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	partial class MainWindow // Parse_Workspace
	{
		/// <summary>
		/// Parses current Text in workspace to number according to current numerical system. 
		/// </summary>
		private double Parse_WorkSpace()
		{
			return parser.Parse(WorkSpace.Text, Numeral_System);
		}
	}
}
