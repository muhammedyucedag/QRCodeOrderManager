namespace QRCodeOrderManager.Application.Exceptions.SocialMedia;

public class UpdateSocialMediaFailedException : BaseException
{
    public UpdateSocialMediaFailedException() : base("Sosyal medya güncellenmedi.")
    {
    }
}