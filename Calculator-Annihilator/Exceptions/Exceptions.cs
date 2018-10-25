using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	public class WorkSpaceParsingException : Exception
	{
		public WorkSpaceParsingException()
		{

		}
		public WorkSpaceParsingException(string message) : base (message)
		{

		}
		public WorkSpaceParsingException(string message ,Exception inner) : base(message, inner)
		{

		}
	}

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
	public class ParsingStringIsNaNException : Exception
	{
		public ParsingStringIsNaNException()
		{

		}
		public ParsingStringIsNaNException(string message) : base(message)
		{

		}
		public ParsingStringIsNaNException(string message, Exception inner) : base(message, inner)
		{

		}
	}
	public class NoActionAsigned : Exception
	{
		public NoActionAsigned()
		{

		}
		public NoActionAsigned(string message) : base(message)
		{

		}
		public NoActionAsigned(string message, Exception inner) : base(message, inner)
		{

		}
	}
}
