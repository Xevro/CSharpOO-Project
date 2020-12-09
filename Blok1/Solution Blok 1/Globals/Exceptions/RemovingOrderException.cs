using System;
using System.Collections.Generic;
using System.Text;

namespace Globals.Exceptions
{
    public class RemovingOrderException : Exception
    {
        public RemovingOrderException() : base() { }
        public RemovingOrderException(string message) : base(message) { }
    }
}
