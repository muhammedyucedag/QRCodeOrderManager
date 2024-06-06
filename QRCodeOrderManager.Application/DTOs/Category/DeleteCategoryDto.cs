using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.DTOs.Category;

public class DeleteCategoryDto : BaseResponse
{
    public DeleteCategoryDto(Guid aboutId)
    {
        Message = $"{aboutId} Numaralı kategori başarılı bir şekilde silinmiştir";
    }
}