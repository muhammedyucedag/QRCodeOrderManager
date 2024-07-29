using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.Features.Commands.SocialMedia.Delete;

public class DeleteSocialMediaCommandResponse : BaseResponse
{
    public DeleteSocialMediaCommandResponse()
    {
        Message = "Sosyal medya başarıyla silindi.";
    }
}