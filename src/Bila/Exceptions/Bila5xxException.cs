using System.Net.Http;

namespace Bila.Exceptions;

public class Bila5xxException : BilaApiException
{
    public Bila5xxException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
