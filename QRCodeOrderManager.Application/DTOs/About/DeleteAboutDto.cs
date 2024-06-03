namespace QRCodeOrderManager.Application.DTOs.About;

public class DeleteAboutDto
{
    public string Message { get; set; }

    public DeleteAboutDto(Guid aboutId)
    {
        Message = $"{aboutId} Numaralı hakkında bilgisi başarılı bir şekilde silinmiştir";
    }
}