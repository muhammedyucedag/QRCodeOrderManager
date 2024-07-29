namespace QRCodeOrderManager.Application.Exceptions.SocialMedia;

public class NotFoundSocialMediaException : BaseException
{
    public NotFoundSocialMediaException() : base("Sosyal medya bulunamadı.")
    {
    }
}