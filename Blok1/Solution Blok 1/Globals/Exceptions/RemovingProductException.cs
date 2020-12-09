using System;

namespace Globals.Exceptions
{
    public class RemovingProductException : Exception
    {
        public RemovingProductException() : base() { }
        public RemovingProductException(string message) : base(message) { }
    }
}
