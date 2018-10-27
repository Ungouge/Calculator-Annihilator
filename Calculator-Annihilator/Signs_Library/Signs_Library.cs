using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	static class Signs_Library
	{
		public static readonly char[][] action_Sings = new char[][]
		{
			new char [] { '^' },
			new char [] { '-', '+' },
			new char [] { '/', '*' }
		};

		public static readonly char[] CommasType = { ',', '.', '٫' }; // if not in someverelse that Parser - to delete
	}
}
