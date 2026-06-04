using System.Net.Http;

namespace Bila.Exceptions;

public class BilaBadRequestException : Bila4xxException
{
    public BilaBadRequestException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
