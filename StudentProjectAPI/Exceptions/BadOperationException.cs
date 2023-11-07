using System;

namespace StudentProjectAPI.Exceptions
{
    public class BadOperationException : Exception
    {
        public BadOperationException(string message)
            : base(message)
        {
        }
    }
}
