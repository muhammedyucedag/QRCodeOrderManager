using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.Features.Commands.Contact.Update;

public class UpdateContactCommandResponse : BaseResponse
{
    public UpdateContactCommandResponse()
    {
        Message =  "Bağlantı bilgisi güncellendi.";
    }
}