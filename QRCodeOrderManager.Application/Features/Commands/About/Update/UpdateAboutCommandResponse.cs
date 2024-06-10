using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.Features.Commands.About.Update;

public class UpdateAboutCommandResponse : BaseResponse
{
    public UpdateAboutCommandResponse()
    {
        Message =  "Hakkında bilgisi güncellendi.";
    }
}