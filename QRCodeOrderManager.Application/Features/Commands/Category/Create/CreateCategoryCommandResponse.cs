using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.Features.Commands.Category.Create;

public class CreateCategoryCommandResponse : BaseResponse
{
    public CreateCategoryCommandResponse()
    {
        Message =  "Kategori bilgisi oluşturuldu.";
    }
}