using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	/// <summary>
	/// 
	/// </summary>
	public class ParsingCharacterIsNoDigitException : Exception
	{
		/// <summary>
		/// The Exception that is thrown when character that is to be parsed to digit is corresponding no digit from current numerical system.
		/// </summary>
		public ParsingCharacterIsNoDigitException()
		{

		}
		public ParsingCharacterIsNoDigitException(string message) : base(message)
		{

		}
		public ParsingCharacterIsNoDigitException(string message, Exception inner) : base(message, inner)
		{

		}
	}

	/// <summary>
	/// The exception that is thrown when there is no operation assigned to given set of data to calculate.
	/// </summary>
	public class NoActionOperationException : Exception
	{
		public NoActionOperationException()
		{

		}
		public NoActionOperationException(string message) : base(message)
		{

		}
		public NoActionOperationException(string message, Exception inner) : base(message, inner)
		{

		}
	}

	/// <summary>
	/// The exception that is thrown when unknow error occurs durring solving an equation.
	/// </summary>
	public class EquationNotSolvedProperlyException : Exception
	{
		public EquationNotSolvedProperlyException()
		{

		}
		public EquationNotSolvedProperlyException(string message) : base(message)
		{

		}
		public EquationNotSolvedProperlyException(string message, Exception inner) : base(message, inner)
		{

		}
	}
}
