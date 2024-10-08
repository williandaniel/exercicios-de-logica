using System;

namespace FifthQuestion.Entities.Exceptions
{
    class OptionException : ApplicationException
    {
        public OptionException(string message) : base(message)
        {
        }
    }
}
