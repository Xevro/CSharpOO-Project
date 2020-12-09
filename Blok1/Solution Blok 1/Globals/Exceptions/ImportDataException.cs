using System;

namespace Globals.Exceptions
{
    public class ImportDataException : Exception
    {
        public ImportDataException() : base() { }
        public ImportDataException(string message) : base(message) { }
    }
}