namespace QRCodeOrderManager.Application.Exceptions.SocialMedia;

public class CreateSocialMediaFailedException : BaseException
{
    public CreateSocialMediaFailedException() : base("Sosyal medya oluşturma işlemi başarısız.")
    {
    }
}