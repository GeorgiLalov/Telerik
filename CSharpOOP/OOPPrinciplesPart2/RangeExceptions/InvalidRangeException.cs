using System;

namespace RangeExceptions
{
    public class InvalidRangeException<T> : Exception
    {
        public InvalidRangeException(string message, T start, T end) : base(message)
        {

        }
    }
}
