using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	public abstract class Element : IElement, IElement_ToString
	{
		public Element() { ; }

		public override string ToString()
		{
			return "";
		}
	}

	public class Operand : Element, IElement, IElement_ToString, IOperand, INot_Outside_Of_Equation
	{
		public char Sign { get; private set; }

		public Operand (char s) : base()
		{
			Sign = s;
		}

		public override string ToString()
		{
			return Sign.ToString();
		}
	}

	public class Bracket : Element
	{
		public Bracket_Pair Pair { get; set; }

		public Bracket() : base() {; }
	}

	public class Open_Bracket : Bracket, IElement_ToString, INot_Outside_The_Close_Bracket, INot_At_The_End
	{
		public Open_Bracket() : base() {; }

		public override string ToString()
		{
			return "(";
		}
	}

	public class Close_Bracket : Bracket, IElement_ToString, INot_Outside_The_Open_Bracket, INot_At_the_Begining
	{
		public Close_Bracket() : base() {; }

		public override string ToString()
		{
			return ")";
		}
	}

	public class Number : Element, IElement_ToString, INumber, INot_Outside_The_Bracket
	{
		public double Value { get; private set; }
			
		public Number(double v) : base()
		{
			Value = v;
		}

		public override string ToString()
		{
			return Value.ToString();
		}
	}
}
