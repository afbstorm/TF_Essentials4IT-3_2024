using System;

namespace Exos_hors_banque.Exceptions
{
    public class BookNotAvailableException : Exception
    {
        public BookNotAvailableException(string message) : base(message)
        {
        }
    }
}
