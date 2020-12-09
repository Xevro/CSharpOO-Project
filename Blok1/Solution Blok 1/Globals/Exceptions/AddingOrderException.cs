using System;

namespace Globals.Exceptions
{
    public class AddingOrderException : Exception
    {
        public AddingOrderException() : base() { }
        public AddingOrderException(string message) : base(message) { }
    }
}