using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	/// <summary>
	/// The Exception that is thrown when character that is to be parsed to digit is corresponding
	/// no digit from current numerical system.
	/// </summary>
	public class ParsingCharacterIsNoDigitException : Exception
	{
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
}
