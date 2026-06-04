using System.Net.Http;

namespace Bila.Exceptions;

public class BilaForbiddenException : Bila4xxException
{
    public BilaForbiddenException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
