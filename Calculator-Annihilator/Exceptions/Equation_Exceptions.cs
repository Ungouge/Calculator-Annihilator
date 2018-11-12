using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
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

	/// <summary>
	/// The exception that is thrown when equation class has empty list of elements,
	/// because given text is empty or correction of incorrectly written equation text left no elements in the equation.
	/// </summary>
	public class EquationIsEmptyException : Exception
	{
		public EquationIsEmptyException()
		{

		}
		public EquationIsEmptyException(string message) : base(message)
		{

		}
		public EquationIsEmptyException(string message, Exception inner) : base(message, inner)
		{

		}
	}
}
