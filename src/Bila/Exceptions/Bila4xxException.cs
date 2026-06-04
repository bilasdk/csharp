using System.Net.Http;

namespace Bila.Exceptions;

public class Bila4xxException : BilaApiException
{
    public Bila4xxException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
