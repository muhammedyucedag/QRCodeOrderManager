using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.Features.Commands.Sorter.Update;

public class UpdateSorterCommandResponse : BaseResponse
{
    public UpdateSorterCommandResponse()
    {
        Message = "Sıralayıcı güncellendi.";
    }
}