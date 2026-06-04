using System.Net.Http;

namespace Bila.Exceptions;

public class BilaUnprocessableEntityException : Bila4xxException
{
    public BilaUnprocessableEntityException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
