using System;

namespace DEV_8
{
    public class UndefinedSexException : ApplicationException
    {
        public string Message { get; set; }
        public UndefinedSexException() { }

        public UndefinedSexException(string message) : base(message)
        {
            Message = message;
        }

        public UndefinedSexException(string message, Exception inner) : base(message, inner) { }
    }
}
