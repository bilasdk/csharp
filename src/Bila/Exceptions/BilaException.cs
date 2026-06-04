using System;
using System.Net.Http;

namespace Bila.Exceptions;

public class BilaException : Exception
{
    public BilaException(string message, Exception? innerException = null)
        : base(message, innerException) { }

    protected BilaException(HttpRequestException? innerException)
        : base(null, innerException) { }
}
