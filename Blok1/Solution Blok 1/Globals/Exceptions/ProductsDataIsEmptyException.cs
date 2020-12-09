using System;

namespace Globals.Exceptions
{
    public class ProductsDataIsEmptyException : Exception
    {
        public ProductsDataIsEmptyException() : base() { }
        public ProductsDataIsEmptyException(string message) : base(message) { }
    }
}
