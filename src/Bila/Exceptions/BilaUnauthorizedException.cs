using System.Net.Http;

namespace Bila.Exceptions;

public class BilaUnauthorizedException : Bila4xxException
{
    public BilaUnauthorizedException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
