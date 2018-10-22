using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Anihilator
{
	partial class Equation
	{
		public class Element : IElement, IElement_ToString
		{
			public Element() { ; }

			public override string ToString()
			{
				return "";
			}
		}

		public class Operand : Element, IElement, IElement_ToString, IOperand
		{
			public char sign;
			public int level;

			public Operand (char s, int l) : base()
			{
				sign = s;
				level = l;
			}

			public override string ToString()
			{
				return sign.ToString();
			}
		}

		public class Bracket : Element
		{

			public Bracket() : base() {; }

			public static void Pair_brackets(Open_Bracket open_Bracket, Close_Bracket close_Bracket)
			{
				open_Bracket.Pair = close_Bracket;
				close_Bracket.Pair = open_Bracket;
			}
		}

		public class Open_Bracket : Bracket, IElement_ToString
		{
			public Close_Bracket Pair { get; set; }
			public Open_Bracket() : base() {; }

			public static void Emergent_Addition_of_Open_Bracket(Equation Eq)
			{
				Open_Bracket X = new Open_Bracket();

				Eq.Elements_Colection.Insert(0, X);
			}

			public override string ToString()
			{
				return "(";
			}
		}

		public class Close_Bracket : Bracket, IElement_ToString
		{
			public Open_Bracket Pair { get; set; }
			public Close_Bracket() : base() {; }

			public override string ToString()
			{
				return ")";
			}
		}

		public class Number : Element, IElement_ToString
		{
			public double Value { get; set; }
			
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
}
