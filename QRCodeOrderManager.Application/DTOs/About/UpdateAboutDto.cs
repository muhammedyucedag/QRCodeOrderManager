namespace QRCodeOrderManager.Application.DTOs.About;

public class UpdateAboutDto
{
    public string Message { get; set; }

    public UpdateAboutDto(Guid aboutId)
    {
        Message = $"{aboutId} Numaralı hakkında bilgisi başarılı bir şekilde güncellenmiştir";
    }
}