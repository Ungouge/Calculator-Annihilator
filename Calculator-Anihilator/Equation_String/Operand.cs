using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Anihilator
{
	partial class Equation
	{
		public class Element : IElement, IElementToString
		{
			static public List<IElement> Elements_List= new List<IElement>();

			public Element()
			{
				Elements_List.Add(this);
			}

			public override string ToString()
			{
				return "";
			}
		}

		public class Operand : Element, IElement, IElementToString
		{
			static public List<Operand> operands_List = new List<Operand>();
			char sign;
			int level;

			public Operand (char s, int l) : base()
			{
				sign = s;
				level = l;
				operands_List.Add(this);
			}

			public override string ToString()
			{
				return sign.ToString();
			}
		}

		public class Bracket : Element, IElement, IElementToString
		{
			int Bracket_Level { get; set; }

			static public List<Bracket> bracket_List = new List<Bracket>();

			public Bracket() : base()
			{
				bracket_List.Add(this);
			}

			public Bracket(char s, int l, Bracket p) : this()
			{
				Bracket_Level = l;
			}

			public static void Emergent_Addition_of_Open_Bracket()
			{
				Open_Bracket X = new Open_Bracket();

				Elements_List.Remove(X);
				Elements_List.Insert(0, X);

				bracket_List.Remove(X);
				bracket_List.Insert(0, X);
			}

			public static void Pair_brackets(Open_Bracket open_Bracket, Close_Bracket close_Bracket)
			{
				open_Bracket.Pair = close_Bracket;
				close_Bracket.Pair = open_Bracket;
			}
		}

		public class Open_Bracket : Bracket, IElement, IElementToString
		{
			public Close_Bracket Pair { get; set; }
			public Open_Bracket() : base() {; }

			public override string ToString()
			{
				return "(";
			}
		}

		public class Close_Bracket : Bracket, IElement, IElementToString
		{
			public Open_Bracket Pair { get; set; }
			public Close_Bracket() : base() {; }

			public override string ToString()
			{
				return ")";
			}
		}

		public class Number : Element, IElement, IElementToString
		{
			public double Value { get; set; }
			static public List<Number> numbers_List = new List<Number>();
			
			public Number(double v) : base()
			{
				Value = v;
				numbers_List.Add(this);
			}

			public override string ToString()
			{
				return Value.ToString();
			}
		}

		/*class Dummy_Operator : Element
		{
			public Dummy_Operator(int pos) : base() { }
		}*/
	}
}
