using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise02_ExceptionHandling.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base (message)
        {
        }
    }
}
