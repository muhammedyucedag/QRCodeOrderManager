using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.Features.Commands.Category.Delete;

public class DeleteCategoryCommandRespone : BaseResponse
{
    public DeleteCategoryCommandRespone()
    {
        Message =  "Kategori bilgisi silindi.";
    }
}