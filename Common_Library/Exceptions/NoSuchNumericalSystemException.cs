using System;

namespace Common_Library
{
    /// <summary>
    /// The exception that is thrown when is given wrong code number of numerical system.
    /// </summary>
    public class NoSuchNumericalSystemException : Exception
    {
        public NoSuchNumericalSystemException()
        {

        }
        public NoSuchNumericalSystemException(string message) : base(message)
        {

        }
        public NoSuchNumericalSystemException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
