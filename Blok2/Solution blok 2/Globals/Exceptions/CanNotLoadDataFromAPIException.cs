using System;

namespace Globals.Exceptions
{
    public class CanNotLoadDataFromAPIException : Exception
    {
        public CanNotLoadDataFromAPIException() : base() { }
        public CanNotLoadDataFromAPIException(string message) : base(message) { }
    }
}
