using System;

namespace Globals.Exceptions
{
    public class InputNotANumberExeption : Exception
    {
        public InputNotANumberExeption() : base() { }
        public InputNotANumberExeption(string message) : base(message) { }
    }
}