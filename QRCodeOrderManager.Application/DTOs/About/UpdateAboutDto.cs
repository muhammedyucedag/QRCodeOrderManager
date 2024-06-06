using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.DTOs.About;

public class UpdateAboutDto : BaseResponse
{
    public UpdateAboutDto(Guid aboutId)
    {
        Message = $"{aboutId} Numaralı hakkında bilgisi başarılı bir şekilde güncellenmiştir";
    }
}