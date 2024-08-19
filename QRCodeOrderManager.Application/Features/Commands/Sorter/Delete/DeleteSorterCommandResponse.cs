using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.Features.Commands.Sorter.Delete;

public class DeleteSorterCommandResponse : BaseResponse
{
    public DeleteSorterCommandResponse()
    {
        Message =  "Sıralayıcı silindi.";
    }
}