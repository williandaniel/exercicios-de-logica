using System;

namespace SecondQuestion
{
    class AgeException : ApplicationException
    {
        public AgeException(string message) :base (message)
        { 
        }
    }
}
