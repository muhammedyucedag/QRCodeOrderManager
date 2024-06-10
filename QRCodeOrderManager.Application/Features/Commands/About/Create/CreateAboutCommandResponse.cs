using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.Features.Commands.About.Create;

public class CreateAboutCommandResponse : BaseResponse
{
    public CreateAboutCommandResponse()
    {
        Message =  "Hakkında bilgisi oluşturuldu.";
    }
}