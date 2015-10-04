using System;

namespace OFX.Types.Exceptions
{
    /// <summary>
    /// Wrapper for exceptions raised by OFX services
    /// </summary>
    public class OfxException : Exception
    {
        public OfxException()
        { }
        public OfxException(string message) : base(message)
        { }
        public OfxException(string message, Exception inner) : base(message, inner)
        { }
    }
}
