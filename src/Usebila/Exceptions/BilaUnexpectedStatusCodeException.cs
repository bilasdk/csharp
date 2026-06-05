using System.Net.Http;

namespace Usebila.Exceptions;

public class BilaUnexpectedStatusCodeException : BilaApiException
{
    public BilaUnexpectedStatusCodeException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
