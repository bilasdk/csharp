using System.Net.Http;

namespace Usebila.Exceptions;

public class BilaBadRequestException : Bila4xxException
{
    public BilaBadRequestException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
