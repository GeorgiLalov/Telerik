using System;

namespace RangeExceptions
{
    public class InvalidRangeException<T> : ApplicationException
    {
        public InvalidRangeException(string message, T start, T end) : base(message)
        {

        }
    }
}
