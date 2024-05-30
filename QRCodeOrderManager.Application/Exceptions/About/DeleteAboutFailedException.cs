namespace QRCodeOrderManager.Application.Exceptions.About;

public class DeleteAboutFailedException : BaseException
{
    public DeleteAboutFailedException() : base("Hakkında bilgisi silinemedi.")
    {
    }
}