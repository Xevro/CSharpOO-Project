using System;

namespace Globals.Exceptions
{
    public class AddingProductException : Exception
    {
        public AddingProductException() : base() { }
        public AddingProductException(string message) : base(message) { }
    }
}