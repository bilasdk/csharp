using System.Net.Http;

namespace Bila.Exceptions;

public class BilaUnexpectedStatusCodeException : BilaApiException
{
    public BilaUnexpectedStatusCodeException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
