using System;

namespace Exos_hors_banque.Exceptions
{
    public class InvalidReturnDateException : Exception
    {
        public InvalidReturnDateException(string message) : base(message)
        {
        }
    }
}
