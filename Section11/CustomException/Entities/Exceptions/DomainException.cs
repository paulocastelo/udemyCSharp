using System;
namespace CustomException.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException (string message) : base (message)
        {
        }
    }
}
