using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.DTOs.About;

public class DeleteAboutDto : BaseResponse
{
    public DeleteAboutDto(Guid aboutId)
    {
        Message = $"{aboutId} Numaralı hakkında bilgisi başarılı bir şekilde silinmiştir";
    }
}