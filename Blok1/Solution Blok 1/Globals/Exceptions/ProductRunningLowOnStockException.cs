using System;

namespace Globals.Exceptions
{
    public class ProductRunningLowOnStockException : Exception
    {
        public ProductRunningLowOnStockException() : base() { }
        public ProductRunningLowOnStockException(string message) : base(message) { }
    }
}