﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	/// <summary>
	/// Static libraries of components for calculation.
	/// </summary>
	static class Signs_Lib
	{
		/// <summary>
		/// Jagged array of operand classes on order of operatin.
		/// </summary>
		public static readonly IOperand[][] Operands = new IOperand[][]
		{
			new IOperand [] { new Expontent() },
			new IOperand [] { new Division(), new Multiplication() },
			new IOperand [] { new Subtraction(), new Addition() }
		};

		/// <summary>
		/// Jagged array of operand characters on order of operatin.
		/// </summary>
		public static readonly char[][] operand_Sings = new char[][]
		{
			new char [] { '^' },
			new char [] { '/', '*' },
			new char [] { '-', '+' }
		};

		/// <summary>
		/// Array of possible to use commas.
		/// </summary>
		public static readonly char[] CommasType = { ',', '.', '٫' }; // if not in someverelse that Parser - to delete
	}
}
