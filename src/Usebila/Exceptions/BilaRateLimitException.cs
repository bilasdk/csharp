using System.Net.Http;

namespace Usebila.Exceptions;

public class BilaRateLimitException : Bila4xxException
{
    public BilaRateLimitException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
