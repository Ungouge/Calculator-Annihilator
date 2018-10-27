using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	partial class MainWindow
	{
		private double Parse_WorkSpace()
		{
			return parser.Parse(WorkSpace.Text, Numeral_System);
		}
	}
}
