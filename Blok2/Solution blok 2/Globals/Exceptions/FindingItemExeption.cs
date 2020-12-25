using System;

namespace Globals.Exceptions
{
    public class FindingItemExeption : Exception
    {
        public FindingItemExeption() : base() { }
        public FindingItemExeption(string message) : base(message) { }
    }
}