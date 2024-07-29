using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.Features.Commands.SocialMedia.Update;

public class UpdateSocialMediaCommandResponse : BaseResponse
{
    public UpdateSocialMediaCommandResponse()
    {
        Message = "Sosyal medya başarılı bir şekilde güncellendi.";
    }
}