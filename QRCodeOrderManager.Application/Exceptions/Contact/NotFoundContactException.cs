namespace QRCodeOrderManager.Application.Exceptions.Contact;

public class NotFoundContactException : BaseException
{
    public NotFoundContactException() : base("Bağlantı Bilgisi Bulunmadı.")
    {
    }
}