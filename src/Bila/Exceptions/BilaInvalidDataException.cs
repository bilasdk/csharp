using System;

namespace Bila.Exceptions;

public class BilaInvalidDataException : BilaException
{
    public BilaInvalidDataException(string message, Exception? innerException = null)
        : base(message, innerException) { }
}
