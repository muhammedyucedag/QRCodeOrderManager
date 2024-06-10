using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.Features.Commands.Category.Update;

public class UpdateCategoryCommandResponse : BaseResponse
{
    public UpdateCategoryCommandResponse()
    {
        Message =  "Kategori bilgisi güncellendi.";
    }
}