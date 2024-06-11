using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.Features.Commands.Contact.Create;

public class CreateContactCommandResponse : BaseResponse
{
    public CreateContactCommandResponse()
    {
        Message =  "Bağlantı bilgisi oluşturuldu.";
    }
}