using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.DTOs.Category;

public class CreateCategoryDto : BaseResponse
{
   public CreateCategoryDto(Guid categoryId)
   {
      Message = $"{categoryId} Numaralı kategori başarılı bir şekilde oluşturuldu";
   }
}