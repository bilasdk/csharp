using System.Net.Http;

namespace Usebila.Exceptions;

public class BilaUnauthorizedException : Bila4xxException
{
    public BilaUnauthorizedException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
