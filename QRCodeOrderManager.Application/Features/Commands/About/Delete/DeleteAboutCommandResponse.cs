using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.Features.Commands.About.Delete;

public class DeleteAboutCommandResponse : BaseResponse
{
    public DeleteAboutCommandResponse()
    {
        Message =  "Hakkında bilgisi silindi.";
    }
}