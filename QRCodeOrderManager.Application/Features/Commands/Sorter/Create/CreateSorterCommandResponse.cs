using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.Features.Commands.Sorter.Create;

public class CreateSorterCommandResponse : BaseResponse 
{
    public CreateSorterCommandResponse()
    {
        Message =  "Sıralayıcı oluşturuldu.";
    }
}