namespace QRCodeOrderManager.Application.Exceptions.Contact;

public class CreateContactFailedException : BaseException
{
    public CreateContactFailedException() : base("Bağlantı Bilgisi Oluşturulmadı.")
    {
    }
}