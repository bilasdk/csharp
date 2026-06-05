using System.Net.Http;

namespace Usebila.Exceptions;

public class BilaNotFoundException : Bila4xxException
{
    public BilaNotFoundException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
