namespace QRCodeOrderManager.Application.Exceptions.About;

public class UpdateAboutFailedException : BaseException
{
    public UpdateAboutFailedException() : base("Hakkında Bilgisi Güncellenmedi.")
    {
    }
}