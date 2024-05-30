using System.Runtime.Serialization;

namespace QRCodeOrderManager.Application.Exceptions;

public abstract class BaseException : Exception
{
    public BaseException(string? message) : base(message)
    {
    }
}