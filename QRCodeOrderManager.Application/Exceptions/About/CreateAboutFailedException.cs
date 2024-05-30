namespace QRCodeOrderManager.Application.Exceptions.About;

public class CreateAboutFailedException : BaseException
{
    public CreateAboutFailedException() : base("Hakkında bilgisi oluşturulmadı.")
    {
    }
}