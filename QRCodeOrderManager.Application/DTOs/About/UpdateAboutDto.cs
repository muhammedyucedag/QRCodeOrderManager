namespace QRCodeOrderManager.Application.DTOs.About;

public class UpdateAboutDto
{
    public Guid id { get; set; }
    public string ImageUrl { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}