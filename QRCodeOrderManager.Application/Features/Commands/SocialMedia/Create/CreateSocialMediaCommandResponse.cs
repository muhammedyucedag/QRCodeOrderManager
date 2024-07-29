using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.Features.Commands.SocialMedia.Create;

public class CreateSocialMediaCommandResponse : BaseResponse
{
    public CreateSocialMediaCommandResponse()
    {
        Message =  "Sosyal medya oluşturuldu.";
    }
}