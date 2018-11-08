using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	/// <summary>
	/// Class containg type of operation in equation. Containg Sings should match up with "Signs_Lib.operand_Sings".
	/// </summary>
	public abstract class Operand : IElement, IElement_ToString, IOperand, IOperand_ToString, INot_Outside_Of_Equation
	{
		public Operand() {; }

		public override string ToString()
		{
			return default(string);
		}

		public string ToString(string operand_Sign)
		{
			return operand_Sign;
		}

		public string ToString(char operand_Sign)
		{
			return operand_Sign.ToString();
		}
	}

	public class Addition : Operand, IElement, IElement_ToString, IOperand, IOperand_ToString, INot_Outside_Of_Equation
	{
		public Addition() { ;}

		public override string ToString()
		{
			return ToString('+');
		}
	}

	public class Subtraction : Operand, IElement, IElement_ToString, IOperand, IOperand_ToString, INot_Outside_Of_Equation
	{
		public Subtraction() {; }

		public override string ToString()
		{
			return ToString('-');
		}
	}

	public class Multiplication : Operand, IElement, IElement_ToString, IOperand, IOperand_ToString, INot_Outside_Of_Equation
	{
		public Multiplication() {; }

		public override string ToString()
		{
			return ToString('*');
		}
	}

	public class Division : Operand, IElement, IElement_ToString, IOperand, IOperand_ToString, INot_Outside_Of_Equation
	{
		public Division() {; }

		public override string ToString()
		{
			return ToString('/');
		}
	}

	public class Expontent : Operand, IElement, IElement_ToString, IOperand, IOperand_ToString, INot_Outside_Of_Equation
	{
		public Expontent() {; }

		public override string ToString()
		{
			return ToString('^');
		}
	}
}
