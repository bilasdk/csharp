using System;
using System.Net.Http;

namespace Bila.Exceptions;

public class BilaIOException : BilaException
{
    public new HttpRequestException InnerException
    {
        get
        {
            if (base.InnerException == null)
            {
                throw new ArgumentNullException();
            }
            return (HttpRequestException)base.InnerException;
        }
    }

    public BilaIOException(string message, HttpRequestException? innerException = null)
        : base(message, innerException) { }
}
