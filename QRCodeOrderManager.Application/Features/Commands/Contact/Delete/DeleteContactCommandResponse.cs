using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.Features.Commands.Contact.Delete;

public class DeleteContactCommandResponse : BaseResponse
{
    public DeleteContactCommandResponse()
    {
        Message =  "Bağlantı bilgisi silindi.";
    }
}