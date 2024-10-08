using System;

namespace ExtraQuestion.Entities.Exceptions
{
    class ProductException : ApplicationException
    {
        public ProductException(string message) : base(message)
        { 
        }
    }
}
