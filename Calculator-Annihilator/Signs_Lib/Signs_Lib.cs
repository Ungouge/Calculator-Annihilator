using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	static class Signs_Lib
	{
		public static readonly IOperand[][] Operands = new IOperand[][]
		{
			new IOperand [] { new Expontent() },
			new IOperand [] { new Division(), new Multiplication() },
			new IOperand [] { new Subtraction(), new Addition() }
		};

		public static readonly char[][] operand_Sings = new char[][]
		{
			new char [] { '^' },
			new char [] { '/', '*' },
			new char [] { '-', '+' }
		};

		public static readonly char[] CommasType = { ',', '.', '٫' }; // if not in someverelse that Parser - to delete
	}
}
