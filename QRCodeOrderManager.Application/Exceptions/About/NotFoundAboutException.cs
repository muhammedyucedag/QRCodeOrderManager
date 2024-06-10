namespace QRCodeOrderManager.Application.Exceptions.About;

public class NotFoundAboutException : BaseException
{
    public NotFoundAboutException() : base("Hakkında bilgisi bulunamadı")
    {
    }
}