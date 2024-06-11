namespace QRCodeOrderManager.Application.Exceptions.Contact;

public class UpdateContactFailedException : BaseException
{
    public UpdateContactFailedException() : base("Bağlantı bilgisi güncellenemedi.")
    {
    }
}