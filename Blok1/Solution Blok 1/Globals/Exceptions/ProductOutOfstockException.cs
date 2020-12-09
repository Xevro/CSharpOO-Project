using System;

namespace Globals.Exceptions
{
    public class ProductOutOfstockException : Exception
    {
        public ProductOutOfstockException() : base() { }
        public ProductOutOfstockException(string message) : base(message) { }
    }
}