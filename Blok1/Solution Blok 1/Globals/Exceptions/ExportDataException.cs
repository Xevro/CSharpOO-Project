using System;

namespace Globals.Exceptions
{
    public class ExportDataException : Exception
    {
        public ExportDataException() : base() { }
        public ExportDataException(string message) : base(message) { }
    }
}
