using System;

namespace Calculator_Annihilator_Library
{
	/// <summary>
	/// Base Class for Open_Bracket and Close_bracket.
	/// </summary>
	public class Bracket
	{
		public Bracket_Pair Pair { get; set; }

		public Bracket() {; }
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
}
