using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class Element : IElement, IElement_ToString
	{
		public Element() { ; }

		public override string ToString()
		{
			return "";
		}
	}

	/// <summary>
	/// Class containg type of operation in equation. Containg Sings should match up with "Signs_Lib.operand_Sings".
	/// </summary>
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

	/// <summary>
	/// Base Class for Open_Bracket and Close_bracket.
	/// </summary>
	public class Bracket : Element
	{
		public Bracket_Pair Pair { get; set; }

		public Bracket() : base() {; }
	}

	/// <summary>
	/// Class represents open bracket in equation, should pair up with close bracket.
	/// </summary>
	public class Open_Bracket : Bracket, IElement_ToString, INot_Outside_The_Close_Bracket, INot_At_The_End
	{
		public Open_Bracket() : base() {; }

		public override string ToString()
		{
			return "(";
		}
	}

	/// <summary>
	/// Class represents close bracket in equation, should pair up with open bracket.
	/// </summary>
	public class Close_Bracket : Bracket, IElement_ToString, INot_Outside_The_Open_Bracket, INot_At_the_Begining
	{
		public Close_Bracket() : base() {; }

		public override string ToString()
		{
			return ")";
		}
	}

	/// <summary>
	/// Contains given value as double type.
	/// </summary>
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
