using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.DTOs.About;

public class CreateAboutDto : BaseResponse
{
    public CreateAboutDto(Guid aboutId)
    {
        Message = $"{aboutId} Numaralı hakkında bilgisi başarılı bir şekilde oluşturuldu";
    }
}